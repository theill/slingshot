# slingshot

Slingshot is a simple Windows application for publishing a file to a pre-defined FTP site.


## Releases

See "releases" section.


### Publishing new version

 * Update "history.txt" with version and date.
 * Update "[assembly: AssemblyVersion("1.2.0.0")]" in "AssemblyInfo.cs"
 * Update "Version" property in .Setup project (accept "ProductCode" change)
 * Rebuild .Setup project
 * Update "Version" property in Web.config (.Site project)
 * Rebuild .Site project (history.txt and .msi is copied to folder)
 * Deploy .Site project

