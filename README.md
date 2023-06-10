# Visual-Basic-Shutdown
Visual Basic .NET关机程序
Imports System.Diagnostics：这行代码引入了System.Diagnostics命名空间，其中包含了可以用于启动进程的类。

Module Module1：这是一个模块定义，它包含了程序的主要逻辑。

Sub Main()：这是程序的主入口点，它会在程序启动时被执行。

Shutdown()：这是一个自定义的子过程（Subroutine），用于执行关机操作。

Dim psi As New ProcessStartInfo("shutdown", "/s /t 0")：创建一个ProcessStartInfo对象，用于指定要启动的进程信息。在这里，我们使用shutdown命令并提供参数/s /t 0来指示系统立即关机。

psi.CreateNoWindow = True：设置CreateNoWindow属性为True，这将防止创建新窗口来显示关机进程。

psi.UseShellExecute = False：设置UseShellExecute属性为False，这将禁止使用操作系统的Shell执行进程。

Process.Start(psi)：使用指定的ProcessStartInfo对象启动关机进程。
