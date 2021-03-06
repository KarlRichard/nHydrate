The installer will install the files in the "c:\Program Files\Widgetsphere\CodeTools" folder. If you are running a 64-bit OS you will need to copy the installed files from the Program Files 32 bit folder to that folder. Once you finish the install, you should be able to open VS.NET and see new menus on the "Tools" menu: Generate, Import, and Verify. These menus are the only interface you have with the model.

To create a new model, right click on a solution and add a new item of "Text File" type. Name is anything you like but change the extension from "txt" to "wsgen". When you open the new "wsgen" file, a designer is loaded with the model. You can edit it much like a database, with tables and columns. However there is metadata for the entities. You can import an existing database into a model or create a model from scratch.

When you generate, you are prompted to generate several projects. The ones most people will care about are the Database Installer and the DAL layer. The others are for more advanced frameworks. Those two projects can be used to create and update a database based on a model; and interface with the database with a persistence layer.

More instructions, documents, and examples are to follow.
