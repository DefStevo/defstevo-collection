Namespace My

  ' Für MyApplication sind folgende Ereignisse verfügbar:
  ' 
  ' Startup: Wird beim Starten der Anwendung noch vor dem Erstellen des Startformulars ausgelöst.
  ' Shutdown: Wird nach dem Schließen aller Anwendungsformulare ausgelöst. Dieses Ereignis wird nicht ausgelöst, wenn die Anwendung nicht normal beendet wird.
  ' UnhandledException: Wird ausgelöst, wenn in der Anwendung eine unbehandelte Ausnahme auftritt.
  ' StartupNextInstance: Wird beim Starten einer Einzelinstanzanwendung ausgelöst, wenn diese bereits aktiv ist. 
  ' NetworkAvailabilityChanged: Wird beim Herstellen oder Trennen der Netzwerkverbindung ausgelöst.
  Partial Friend Class MyApplication
    Protected Overrides Function OnInitialize( _
    ByVal commandLineArgs As _
    System.Collections.ObjectModel.ReadOnlyCollection(Of String) _
    ) As Boolean
      Me.MinimumSplashScreenDisplayTime = 5000
      Return MyBase.OnInitialize(commandLineArgs)
    End Function
  End Class

End Namespace

