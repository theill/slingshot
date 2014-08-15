A shell-extension for all versions of Windows allowing you to copy a file to a public FTP server by right-clicking any file or folder in Explorer and select "Sling to Public Site".

Once uploaded you will get an unique URL you may share with your friends.

That's it.


## Releases

See "releases" section.


### Publishing new version

+ Update "history.txt" with version and date.
+ Update "[assembly: AssemblyVersion("1.2.0.0")]" in "AssemblyInfo.cs"
+ Update "Version" property in .Setup project (accept "ProductCode" change)
+ Rebuild .Setup project
+ Update "Version" property in Web.config (.Site project)
+ Rebuild .Site project (history.txt and .msi is copied to folder)
+ Deploy .Site project

