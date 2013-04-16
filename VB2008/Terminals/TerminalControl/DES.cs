/* ---------------------------------------------------------------------------
 *
 * Copyright (c) Routrek Networks, Inc.    All Rights Reserved..
 * 
 * This file is a part of the Granados SSH Client Library that is subject to
 * the license included in the distributed package.
 * You may not use this file except in compliance with the license.
 * 
 * ---------------------------------------------------------------------------
 * 
 * I implemented this algorithm with reference to following products or books though the algorithm is known publicly.
 *   * MindTerm ( AppGate Network Security )
 *   * Applied Cryptography ( Bruce Schneier )
 * 
 */
using System;

namespace Routrek.Crypto
{
	public class DES
	{
		private const int BLOCK_SIZE = 8; // bytes in a data-block

		uint[] _key;
		byte[] _iv;
		byte[] _temp;

		public DES() {
			_key = new uint[32];
			_iv = new byte[8];
			_temp = new byte[8];
		}
		public void SetIV(byte[] newiv) {
			Array.Copy(newiv, 0, _iv, 0, _iv.Length);
		}
		public void SetIV(byte[] newiv, int offset) {
			Array.Copy(newiv, offset, _iv, 0, _iv.Length);
		}

		public void InitializeKey(byte[] key, int offset)
		{
			uint i, c, d, t, s, shifts;

			c = CipherUtil.GetIntLE(key, offset+0);
			d = CipherUtil.GetIntLE(key, offset+4);

			t  = ((d >> 4) ^ c)  & 0x0f0f0f0f;
			c ^= t;
			d ^= t << 4;
			t = (((c << (16 - (-2))) ^ c) & 0xcccc0000);
			c = c ^ t ^ (t >> (16 - (-2)));
			t = (((d << (16 - (-2))) ^ d) & 0xcccc0000);
			d = d ^ t ^ (t >> (16 - (-2)));
			t  = ((d >> 1) ^ c)  & 0x55555555;
			c ^= t;
			d ^= t << 1;
			t  = ((c >> 8) ^ d)  & 0x00ff00ff;
			d ^= t;
			c ^= t << 8;
			t  = ((d >> 1) ^ c)  & 0x55555555;
			c ^= t;
			d ^= t << 1;

			d  = ((d & 0xff) << 16) | (d & 0xff00) |
				((d >> 16) & 0xff) | ((c >> 4) & 0xf000000);
			c &= 0x0fffffff;
			shifts = 0x7efc;

			for(i = 0; i < 16; i++) {
				if((shifts & 1) != 0) {
				c = ((c >> 2) | (c << 26));
				d = ((d >> 2) | (d << 26));
				} else {
				c = ((c >> 1) | (c << 27));
				d = ((d >> 1) | (d << 27));
				}
				shifts >>= 1;
				c &= 0x0fffffff;
				d &= 0x0fffffff;

				s = SKB[0, (c) & 0x3f] |
				SKB[1, ((c >> 6 ) & 0x03)|((c >> 7 ) & 0x3c)] |
				SKB[2, ((c >> 13) & 0x0f)|((c >> 14) & 0x30)] |
				SKB[3, ((c >> 20) & 0x01)|((c >> 21) & 0x06) | ((c >> 22) & 0x38)];

				t = SKB[4, (d) & 0x3f] |
				SKB[5, ((d >> 7 ) & 0x03) | ((d >> 8 ) & 0x3c)] |
				SKB[6,  (d >> 15) & 0x3f				] |
				SKB[7, ((d >> 21) & 0x0f) | ((d >> 22) & 0x30)];

				_key[i * 2]	   = ((t << 16) | (s & 0xffff));
				s						 = ((s >> 16) | (t & 0xffff0000));
				_key[(i * 2) + 1] =  (s << 4)  | (s >> 28);
			}
		}

		public void BlockEncrypt(byte[] input, int inOffset, byte[] output, int outOffset) {
			uint t;
			int i;
			uint[] lr = new uint[2];

			lr[0] = CipherUtil.GetIntLE(input, inOffset);
			lr[1] = CipherUtil.GetIntLE(input, inOffset + 4);

			initPerm(lr);

			t = (lr[1] << 1) | (lr[1] >> 31);
			lr[1] = (lr[0] << 1) | (lr[0] >> 31);
			lr[0] = t;

			for (i = 0; i < 32; i += 4) {
				desCipher1(lr, i);
				desCipher2(lr, i + 2);
			}

			lr[0] = (lr[0] >> 1) | (lr[0] << 31);
			lr[1] = (lr[1] >> 1) | (lr[1] << 31);

			finalPerm(lr);

			CipherUtil.PutIntLE(lr[0], output, outOffset);
			CipherUtil.PutIntLE(lr[1], output, outOffset + 4);
		}

		public void BlockDecrypt(byte[] input, int inOffset, byte[] output, int outOffset) {
			uint t;
			int i;
			uint[] lr = new uint[2];

			lr[0] = CipherUtil.GetIntLE(input, inOffset);
			lr[1] = CipherUtil.GetIntLE(input, inOffset + 4);

			initPerm(lr);

			t = (lr[1] << 1) | (lr[1] >> 31);
			lr[1] = (lr[0] << 1) | (lr[0] >> 31);
			lr[0] = t;

			for (i = 30; i > 0; i -= 4) {
				desCipher1(lr, i);
				desCipher2(lr, i - 2);
			}

			lr[0] = (lr[0] >> 1) | (lr[0] << 31);
			lr[1] = (lr[1] >> 1) | (lr[1] << 31);

			finalPerm(lr);

			CipherUtil.PutIntLE(lr[0], output, outOffset);
			CipherUtil.PutIntLE(lr[1], output, outOffset + 4);
		}

		private void desCipher1(uint[] lr, int i) {
			uint u = lr[1] ^ _key[i	];
			uint t = lr[1] ^ _key[i + 1];
			t = ((t >> 4) + (t << 28));
			lr[0] ^= (SPTRANS[1, (t	   ) & 0x3f] |
				SPTRANS[3, (t >> 8 ) & 0x3f] |
				SPTRANS[5, (t >> 16) & 0x3f] |
				SPTRANS[7, (t >> 24) & 0x3f] |
				SPTRANS[0, (u	   ) & 0x3f] |
				SPTRANS[2, (u >> 8 ) & 0x3f] |
				SPTRANS[4, (u >> 16) & 0x3f] |
				SPTRANS[6, (u >> 24) & 0x3f]);
		}

		private void desCipher2(uint[] lr, int i) {
			uint u = lr[0] ^ _key[i	];
			uint t = lr[0] ^ _key[i + 1];
			t = ((t >> 4) + (t << 28));
			lr[1] ^= (SPTRANS[1, (t	   ) & 0x3f] |
				SPTRANS[3, (t >> 8 ) & 0x3f] |
				SPTRANS[5, (t >> 16) & 0x3f] |
				SPTRANS[7, (t >> 24) & 0x3f] |
				SPTRANS[0, (u	   ) & 0x3f] |
				SPTRANS[2, (u >> 8 ) & 0x3f] |
				SPTRANS[4, (u >> 16) & 0x3f] |
				SPTRANS[6, (u >> 24) & 0x3f]);
		}

		private static void initPerm(uint[] lr) {
			uint t  = ((lr[1] >> 4) ^ lr[0])  & 0x0f0f0f0f;
			lr[0] ^= t;
			lr[1] ^= t << 4;
			t  = ((lr[0] >> 16) ^ lr[1]) & 0x0000ffff;
			lr[1] ^= t;
			lr[0] ^= t << 16;
			t  = ((lr[1] >> 2) ^ lr[0])  & 0x33333333;
			lr[0] ^= t;
			lr[1] ^= t << 2;
			t  = ((lr[0] >> 8) ^ lr[1])  & 0x00ff00ff;
			lr[1] ^= t;
			lr[0] ^= t << 8;
			t  = ((lr[1] >> 1) ^ lr[0])  & 0x55555555;
			lr[0] ^= t;
			lr[1] ^= t << 1;
		}

		private static void finalPerm(uint[] lr) {
			uint t  = ((lr[1] >> 1) ^ lr[0])  & 0x55555555;
			lr[0] ^= t;
			lr[1] ^= t << 1;
			t  = ((lr[0] >> 8) ^ lr[1])  & 0x00ff00ff;
			lr[1] ^= t;
			lr[0] ^= t << 8;
			t  = ((lr[1] >> 2) ^ lr[0])  & 0x33333333;
			lr[0] ^= t;
			lr[1] ^= t << 2;
			t  = ((lr[0] >> 16) ^ lr[1]) & 0x0000ffff;
			lr[1] ^= t;
			lr[0] ^= t << 16;
			t  = ((lr[1] >> 4) ^ lr[0])  & 0x0f0f0f0f;
			lr[0] ^= t;
			lr[1] ^= t << 4;
		}
	  
		public void EncryptCBC(byte[] input, int inputOffset, int inputLen, byte[] output, int outputOffset) {
			int nBlocks = inputLen / 8;
			for(int bc = 0; bc < nBlocks; bc++) {
				CipherUtil.BlockXor(input, inputOffset, 8, _iv, 0);
				BlockEncrypt(_iv, 0, output, outputOffset);
				Array.Copy(output, outputOffset, _iv, 0, 8);
				inputOffset  += 8;
				outputOffset += 8;
			}
		}
		
		public void DecryptCBC(byte[] input, int inputOffset, int inputLen, byte[] output, int outputOffset) {
			int nBlocks = inputLen / 8;
			for(int bc = 0; bc < nBlocks; bc++)	{
				BlockDecrypt(input, inputOffset, _temp, 0);
				for(int i = 0; i < 8; i++) {
					_temp[i] ^= _iv[i];
					_iv[i] = input[inputOffset + i];
					output[outputOffset + i] = _temp[i];
				}
				inputOffset  += 8;
				outputOffset += 8;
			}
		}
		
		/* 
		* Copyright (C) 1993 Eric Young
		*/
		private static readonly uint[,] SKB = new uint[,] {
		/* for C bits (numbered as per FIPS 46) 1 2 3 4 5 6 */
		{ 0x00000000,0x00000010,0x20000000,0x20000010,
		0x00010000,0x00010010,0x20010000,0x20010010,
		0x00000800,0x00000810,0x20000800,0x20000810,
		0x00010800,0x00010810,0x20010800,0x20010810,
		0x00000020,0x00000030,0x20000020,0x20000030,
		0x00010020,0x00010030,0x20010020,0x20010030,
		0x00000820,0x00000830,0x20000820,0x20000830,
		0x00010820,0x00010830,0x20010820,0x20010830,
		0x00080000,0x00080010,0x20080000,0x20080010,
		0x00090000,0x00090010,0x20090000,0x20090010,
		0x00080800,0x00080810,0x20080800,0x20080810,
		0x00090800,0x00090810,0x20090800,0x20090810,
		0x00080020,0x00080030,0x20080020,0x20080030,
		0x00090020,0x00090030,0x20090020,0x20090030,
		0x00080820,0x00080830,0x20080820,0x20080830,
		0x00090820,0x00090830,0x20090820,0x20090830 },
		/* for C bits (numbered as per FIPS 46) 7 8 10 11 12 13 */
		{ 0x00000000,0x02000000,0x00002000,0x02002000,
		0x00200000,0x02200000,0x00202000,0x02202000,
		0x00000004,0x02000004,0x00002004,0x02002004,
		0x00200004,0x02200004,0x00202004,0x02202004,
		0x00000400,0x02000400,0x00002400,0x02002400,
		0x00200400,0x02200400,0x00202400,0x02202400,
		0x00000404,0x02000404,0x00002404,0x02002404,
		0x00200404,0x02200404,0x00202404,0x02202404,
		0x10000000,0x12000000,0x10002000,0x12002000,
		0x10200000,0x12200000,0x10202000,0x12202000,
		0x10000004,0x12000004,0x10002004,0x12002004,
		0x10200004,0x12200004,0x10202004,0x12202004,
		0x10000400,0x12000400,0x10002400,0x12002400,
		0x10200400,0x12200400,0x10202400,0x12202400,
		0x10000404,0x12000404,0x10002404,0x12002404,
		0x10200404,0x12200404,0x10202404,0x12202404 },
		/* for C bits (numbered as per FIPS 46) 14 15 16 17 19 20 */
		{ 0x00000000,0x00000001,0x00040000,0x00040001,
		0x01000000,0x01000001,0x01040000,0x01040001,
		0x00000002,0x00000003,0x00040002,0x00040003,
		0x01000002,0x01000003,0x01040002,0x01040003,
		0x00000200,0x00000201,0x00040200,0x00040201,
		0x01000200,0x01000201,0x01040200,0x01040201,
		0x00000202,0x00000203,0x00040202,0x00040203,
		0x01000202,0x01000203,0x01040202,0x01040203,
		0x08000000,0x08000001,0x08040000,0x08040001,
		0x09000000,0x09000001,0x09040000,0x09040001,
		0x08000002,0x08000003,0x08040002,0x08040003,
		0x09000002,0x09000003,0x09040002,0x09040003,
		0x08000200,0x08000201,0x08040200,0x08040201,
		0x09000200,0x09000201,0x09040200,0x09040201,
		0x08000202,0x08000203,0x08040202,0x08040203,
		0x09000202,0x09000203,0x09040202,0x09040203 },
		/* for C bits (numbered as per FIPS 46) 21 23 24 26 27 28 */
		{ 0x00000000,0x00100000,0x00000100,0x00100100,
		0x00000008,0x00100008,0x00000108,0x00100108,
		0x00001000,0x00101000,0x00001100,0x00101100,
		0x00001008,0x00101008,0x00001108,0x00101108,
		0x04000000,0x04100000,0x04000100,0x04100100,
		0x04000008,0x04100008,0x04000108,0x04100108,
		0x04001000,0x04101000,0x04001100,0x04101100,
		0x04001008,0x04101008,0x04001108,0x04101108,
		0x00020000,0x00120000,0x00020100,0x00120100,
		0x00020008,0x00120008,0x00020108,0x00120108,
		0x00021000,0x00121000,0x00021100,0x00121100,
		0x00021008,0x00121008,0x00021108,0x00121108,
		0x04020000,0x04120000,0x04020100,0x04120100,
		0x04020008,0x04120008,0x04020108,0x04120108,
		0x04021000,0x04121000,0x04021100,0x04121100,
		0x04021008,0x04121008,0x04021108,0x04121108 },
		/* for D bits (numbered as per FIPS 46) 1 2 3 4 5 6 */
		{ 0x00000000,0x10000000,0x00010000,0x10010000,
		0x00000004,0x10000004,0x00010004,0x10010004,
		0x20000000,0x30000000,0x20010000,0x30010000,
		0x20000004,0x30000004,0x20010004,0x30010004,
		0x00100000,0x10100000,0x00110000,0x10110000,
		0x00100004,0x10100004,0x00110004,0x10110004,
		0x20100000,0x30100000,0x20110000,0x30110000,
		0x20100004,0x30100004,0x20110004,0x30110004,
		0x00001000,0x10001000,0x00011000,0x10011000,
		0x00001004,0x10001004,0x00011004,0x10011004,
		0x20001000,0x30001000,0x20011000,0x30011000,
		0x20001004,0x30001004,0x20011004,0x30011004,
		0x00101000,0x10101000,0x00111000,0x10111000,
		0x00101004,0x10101004,0x00111004,0x10111004,
		0x20101000,0x30101000,0x20111000,0x30111000,
		0x20101004,0x30101004,0x20111004,0x30111004 },
		/* for D bits (numbered as per FIPS 46) 8 9 11 12 13 14 */
		{ 0x00000000,0x08000000,0x00000008,0x08000008,
		0x00000400,0x08000400,0x00000408,0x08000408,
		0x00020000,0x08020000,0x00020008,0x08020008,
		0x00020400,0x08020400,0x00020408,0x08020408,
		0x00000001,0x08000001,0x00000009,0x08000009,
		0x00000401,0x08000401,0x00000409,0x08000409,
		0x00020001,0x08020001,0x00020009,0x08020009,
		0x00020401,0x08020401,0x00020409,0x08020409,
		0x02000000,0x0A000000,0x02000008,0x0A000008,
		0x02000400,0x0A000400,0x02000408,0x0A000408,
		0x02020000,0x0A020000,0x02020008,0x0A020008,
		0x02020400,0x0A020400,0x02020408,0x0A020408,
		0x02000001,0x0A000001,0x02000009,0x0A000009,
		0x02000401,0x0A000401,0x02000409,0x0A000409,
		0x02020001,0x0A020001,0x02020009,0x0A020009,
		0x02020401,0x0A020401,0x02020409,0x0A020409 },
		/* for D bits (numbered as per FIPS 46) 16 17 18 19 20 21 */
		{ 0x00000000,0x00000100,0x00080000,0x00080100,
		0x01000000,0x01000100,0x01080000,0x01080100,
		0x00000010,0x00000110,0x00080010,0x00080110,
		0x01000010,0x01000110,0x01080010,0x01080110,
		0x00200000,0x00200100,0x00280000,0x00280100,
		0x01200000,0x01200100,0x01280000,0x01280100,
		0x00200010,0x00200110,0x00280010,0x00280110,
		0x01200010,0x01200110,0x01280010,0x01280110,
		0x00000200,0x00000300,0x00080200,0x00080300,
		0x01000200,0x01000300,0x01080200,0x01080300,
		0x00000210,0x00000310,0x00080210,0x00080310,
		0x01000210,0x01000310,0x01080210,0x01080310,
		0x00200200,0x00200300,0x00280200,0x00280300,
		0x01200200,0x01200300,0x01280200,0x01280300,
		0x00200210,0x00200310,0x00280210,0x00280310,
		0x01200210,0x01200310,0x01280210,0x01280310 },
		/* for D bits (numbered as per FIPS 46) 22 23 24 25 27 28 */
		{ 0x00000000,0x04000000,0x00040000,0x04040000,
		0x00000002,0x04000002,0x00040002,0x04040002,
		0x00002000,0x04002000,0x00042000,0x04042000,
		0x00002002,0x04002002,0x00042002,0x04042002,
		0x00000020,0x04000020,0x00040020,0x04040020,
		0x00000022,0x04000022,0x00040022,0x04040022,
		0x00002020,0x04002020,0x00042020,0x04042020,
		0x00002022,0x04002022,0x00042022,0x04042022,
		0x00000800,0x04000800,0x00040800,0x04040800,
		0x00000802,0x04000802,0x00040802,0x04040802,
		0x00002800,0x04002800,0x00042800,0x04042800,
		0x00002802,0x04002802,0x00042802,0x04042802,
		0x00000820,0x04000820,0x00040820,0x04040820,
		0x00000822,0x04000822,0x00040822,0x04040822,
		0x00002820,0x04002820,0x00042820,0x04042820,
		0x00002822,0x04002822,0x00042822,0x04042822 }
		};

		private static uint[,] SPTRANS = new uint[,] {
		/* nibble 0 */
		{ 0x00820200, 0x00020000, 0x80800000, 0x80820200,
		0x00800000, 0x80020200, 0x80020000, 0x80800000,
		0x80020200, 0x00820200, 0x00820000, 0x80000200,
		0x80800200, 0x00800000, 0x00000000, 0x80020000,
		0x00020000, 0x80000000, 0x00800200, 0x00020200,
		0x80820200, 0x00820000, 0x80000200, 0x00800200,
		0x80000000, 0x00000200, 0x00020200, 0x80820000,
		0x00000200, 0x80800200, 0x80820000, 0x00000000,
		0x00000000, 0x80820200, 0x00800200, 0x80020000,
		0x00820200, 0x00020000, 0x80000200, 0x00800200,
		0x80820000, 0x00000200, 0x00020200, 0x80800000,
		0x80020200, 0x80000000, 0x80800000, 0x00820000,
		0x80820200, 0x00020200, 0x00820000, 0x80800200,
		0x00800000, 0x80000200, 0x80020000, 0x00000000,
		0x00020000, 0x00800000, 0x80800200, 0x00820200,
		0x80000000, 0x80820000, 0x00000200, 0x80020200 },

		/* nibble 1 */
		{ 0x10042004, 0x00000000, 0x00042000, 0x10040000,
		0x10000004, 0x00002004, 0x10002000, 0x00042000,
		0x00002000, 0x10040004, 0x00000004, 0x10002000,
		0x00040004, 0x10042000, 0x10040000, 0x00000004,
		0x00040000, 0x10002004, 0x10040004, 0x00002000,
		0x00042004, 0x10000000, 0x00000000, 0x00040004,
		0x10002004, 0x00042004, 0x10042000, 0x10000004,
		0x10000000, 0x00040000, 0x00002004, 0x10042004,
		0x00040004, 0x10042000, 0x10002000, 0x00042004,
		0x10042004, 0x00040004, 0x10000004, 0x00000000,
		0x10000000, 0x00002004, 0x00040000, 0x10040004,
		0x00002000, 0x10000000, 0x00042004, 0x10002004,
		0x10042000, 0x00002000, 0x00000000, 0x10000004,
		0x00000004, 0x10042004, 0x00042000, 0x10040000,
		0x10040004, 0x00040000, 0x00002004, 0x10002000,
		0x10002004, 0x00000004, 0x10040000, 0x00042000 },

		/* nibble 2 */
		{ 0x41000000, 0x01010040, 0x00000040, 0x41000040,
		0x40010000, 0x01000000, 0x41000040, 0x00010040,
		0x01000040, 0x00010000, 0x01010000, 0x40000000,
		0x41010040, 0x40000040, 0x40000000, 0x41010000,
		0x00000000, 0x40010000, 0x01010040, 0x00000040,
		0x40000040, 0x41010040, 0x00010000, 0x41000000,
		0x41010000, 0x01000040, 0x40010040, 0x01010000,
		0x00010040, 0x00000000, 0x01000000, 0x40010040,
		0x01010040, 0x00000040, 0x40000000, 0x00010000,
		0x40000040, 0x40010000, 0x01010000, 0x41000040,
		0x00000000, 0x01010040, 0x00010040, 0x41010000,
		0x40010000, 0x01000000, 0x41010040, 0x40000000,
		0x40010040, 0x41000000, 0x01000000, 0x41010040,
		0x00010000, 0x01000040, 0x41000040, 0x00010040,
		0x01000040, 0x00000000, 0x41010000, 0x40000040,
		0x41000000, 0x40010040, 0x00000040, 0x01010000 },

		/* nibble 3 */
		{ 0x00100402, 0x04000400, 0x00000002, 0x04100402,
		0x00000000, 0x04100000, 0x04000402, 0x00100002,
		0x04100400, 0x04000002, 0x04000000, 0x00000402,
		0x04000002, 0x00100402, 0x00100000, 0x04000000,
		0x04100002, 0x00100400, 0x00000400, 0x00000002,
		0x00100400, 0x04000402, 0x04100000, 0x00000400,
		0x00000402, 0x00000000, 0x00100002, 0x04100400,
		0x04000400, 0x04100002, 0x04100402, 0x00100000,
		0x04100002, 0x00000402, 0x00100000, 0x04000002,
		0x00100400, 0x04000400, 0x00000002, 0x04100000,
		0x04000402, 0x00000000, 0x00000400, 0x00100002,
		0x00000000, 0x04100002, 0x04100400, 0x00000400,
		0x04000000, 0x04100402, 0x00100402, 0x00100000,
		0x04100402, 0x00000002, 0x04000400, 0x00100402,
		0x00100002, 0x00100400, 0x04100000, 0x04000402,
		0x00000402, 0x04000000, 0x04000002, 0x04100400 },

		/* nibble 4 */
		{ 0x02000000, 0x00004000, 0x00000100, 0x02004108,
		0x02004008, 0x02000100, 0x00004108, 0x02004000,
		0x00004000, 0x00000008, 0x02000008, 0x00004100,
		0x02000108, 0x02004008, 0x02004100, 0x00000000,
		0x00004100, 0x02000000, 0x00004008, 0x00000108,
		0x02000100, 0x00004108, 0x00000000, 0x02000008,
		0x00000008, 0x02000108, 0x02004108, 0x00004008,
		0x02004000, 0x00000100, 0x00000108, 0x02004100,
		0x02004100, 0x02000108, 0x00004008, 0x02004000,
		0x00004000, 0x00000008, 0x02000008, 0x02000100,
		0x02000000, 0x00004100, 0x02004108, 0x00000000,
		0x00004108, 0x02000000, 0x00000100, 0x00004008,
		0x02000108, 0x00000100, 0x00000000, 0x02004108,
		0x02004008, 0x02004100, 0x00000108, 0x00004000,
		0x00004100, 0x02004008, 0x02000100, 0x00000108,
		0x00000008, 0x00004108, 0x02004000, 0x02000008 },

		/* nibble 5 */
		{ 0x20000010, 0x00080010, 0x00000000, 0x20080800,
		0x00080010, 0x00000800, 0x20000810, 0x00080000,
		0x00000810, 0x20080810, 0x00080800, 0x20000000,
		0x20000800, 0x20000010, 0x20080000, 0x00080810,
		0x00080000, 0x20000810, 0x20080010, 0x00000000,
		0x00000800, 0x00000010, 0x20080800, 0x20080010,
		0x20080810, 0x20080000, 0x20000000, 0x00000810,
		0x00000010, 0x00080800, 0x00080810, 0x20000800,
		0x00000810, 0x20000000, 0x20000800, 0x00080810,
		0x20080800, 0x00080010, 0x00000000, 0x20000800,
		0x20000000, 0x00000800, 0x20080010, 0x00080000,
		0x00080010, 0x20080810, 0x00080800, 0x00000010,
		0x20080810, 0x00080800, 0x00080000, 0x20000810,
		0x20000010, 0x20080000, 0x00080810, 0x00000000,
		0x00000800, 0x20000010, 0x20000810, 0x20080800,
		0x20080000, 0x00000810, 0x00000010, 0x20080010 },

		/* nibble 6 */
		{ 0x00001000, 0x00000080, 0x00400080, 0x00400001,
		0x00401081, 0x00001001, 0x00001080, 0x00000000,
		0x00400000, 0x00400081, 0x00000081, 0x00401000,
		0x00000001, 0x00401080, 0x00401000, 0x00000081,
		0x00400081, 0x00001000, 0x00001001, 0x00401081,
		0x00000000, 0x00400080, 0x00400001, 0x00001080,
		0x00401001, 0x00001081, 0x00401080, 0x00000001,
		0x00001081, 0x00401001, 0x00000080, 0x00400000,
		0x00001081, 0x00401000, 0x00401001, 0x00000081,
		0x00001000, 0x00000080, 0x00400000, 0x00401001,
		0x00400081, 0x00001081, 0x00001080, 0x00000000,
		0x00000080, 0x00400001, 0x00000001, 0x00400080,
		0x00000000, 0x00400081, 0x00400080, 0x00001080,
		0x00000081, 0x00001000, 0x00401081, 0x00400000,
		0x00401080, 0x00000001, 0x00001001, 0x00401081,
		0x00400001, 0x00401080, 0x00401000, 0x00001001 },

		/* nibble 7 */
		{ 0x08200020, 0x08208000, 0x00008020, 0x00000000,
		0x08008000, 0x00200020, 0x08200000, 0x08208020,
		0x00000020, 0x08000000, 0x00208000, 0x00008020,
		0x00208020, 0x08008020, 0x08000020, 0x08200000,
		0x00008000, 0x00208020, 0x00200020, 0x08008000,
		0x08208020, 0x08000020, 0x00000000, 0x00208000,
		0x08000000, 0x00200000, 0x08008020, 0x08200020,
		0x00200000, 0x00008000, 0x08208000, 0x00000020,
		0x00200000, 0x00008000, 0x08000020, 0x08208020,
		0x00008020, 0x08000000, 0x00000000, 0x00208000,
		0x08200020, 0x08008020, 0x08008000, 0x00200020,
		0x08208000, 0x00000020, 0x00200020, 0x08008000,
		0x08208020, 0x00200000, 0x08200000, 0x08000020,
		0x00208000, 0x00008020, 0x08008020, 0x08200000,
		0x00000020, 0x08208000, 0x00208020, 0x00000000,
		0x08000000, 0x08200020, 0x00008000, 0x00208020 }
		};

	}
}