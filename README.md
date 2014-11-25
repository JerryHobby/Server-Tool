Server-Tool
===========

Web Server Monitoring Tools


I wanted to build an app from scratch in order to very cleanly test some program design and Visual Studio technologies.  This Solution has three projects.  A FORMS app, a CONSOLE app, and a Network DLL.  The design concept is to put all functionality inside the DLL and only the user interface components into the other two projects.

The goal of this app is to provide some monitoring for servers and networks.  Features may include:

- Routine bandwidth measurements
- Routine connections to various ports.
- Database tracking of the results.
- Smart modules to perform more indepth "peeking" into mail servers, database servers, etc.
- Notifications based on threshholds.
- Connection to a server-side element that monitors things on the server such as disk space, memory, etc.

The idea is that modules will be implemented into the DLL which support various scripted or configurable routines that can be scheduled and logged over time.  The possibilities are endless.


