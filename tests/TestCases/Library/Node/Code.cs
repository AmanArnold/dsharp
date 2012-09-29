using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using NodeApi;
using NodeApi.Network;

[assembly:ScriptAssembly("app")]
[assembly:ScriptTemplate(@"
// {name}.js
//

!function($global) {
  {dependenciesLookup}

  {script}
}(this);
")]

[ScriptModule]
internal static class App {

    static App() {
        Http.CreateServer(delegate(HttpServerRequest request, HttpServerResponse response) {
            response.WriteHead(HttpStatusCode.OK,
                               new Dictionary<string, string>("Content-Type", "text/html"));
            response.End("Hello Node World, from Script#!");
        }).Listen(Script.Value(Node.Process.Environment["port"], 8888));
    }
}
