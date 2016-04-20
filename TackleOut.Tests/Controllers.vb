Imports System.Text
Imports System.Web.Mvc
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports TackleOut.Web

Namespace TackleOutTests.Controllers

    <TestClass()>
    Public Class HomeControllerTest

        <TestMethod()>
        Public Sub TestIndexView()
            Dim controller = New HomeController()
            Dim result As ViewResult = controller.Index()
            Assert.AreEqual("Index", result.ViewName)
        End Sub

    End Class

End Namespace
