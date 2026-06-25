# How to Add a Blazor File Manager to the Blazor Server App?

**Repository Description**  
This repository contains a Blazor Server sample that demonstrates how to configure and add the Syncfusion **[Blazor File Manager](https://www.syncfusion.com/blazor-components/blazor-file-manager?utm_source=github&utm_medium=listing&utm_campaign=blazor-file-manager-github-samples)** component to a Blazor Server application. The File Manager provides a graphical user interface for managing files and folders, including browsing, editing, sorting, and performing common file operations.

The sample serves as a quick‑start project to help developers understand how to integrate the Blazor File Manager and manage the file system within a Blazor Server environment.

## Project Overview
The purpose of this project is to help developers learn how to add and configure the Syncfusion Blazor File Manager in a Blazor Server application. It covers the basic setup and highlights key capabilities such as navigating folders, performing file operations, and customizing the File Manager layout and behavior.

## Features and Benefits

### Customizable layout design
The Blazor File Manager UI consists of toolbar, navigation pane, and content pane sections through which the files or folders in the file system can be accessed and managed. The complete layout can be customized with features like right-to-left alignment, enabling or disabling the toolbar and navigation pane, and switching between views.
### Toolbar
The toolbar contains the list of tools for performing various operations like file upload or download and view switching. The toolbar can also be configured to add any custom functionality to be performed with the file system.
### Navigation pane
The navigation pane allows quick and direct access to a file or folder in a file system where the entire folder hierarchy is listed using a tree view. This can be made visible or hidden as needed.
### Content pane
The content pane displays the files and folders in the file system. The files in the content pane can be displayed in either large icons view or details view.
### File operations
The Blazor File Manager component includes all the common [operations](https://blazor.syncfusion.com/documentation/file-manager/file-operations?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples) needed for managing a file system. It includes copy, move, upload, download, edit, create, delete, and sort.
### File upload and download
The Blazor File Manager component allows the easy uploading and downloading of files in a file system.
### Sorting
Files and folders in the file system can be sorted in either ascending or descending order simply by clicking the column header. Files and folders can be sorted based on name, date created, size, etc.
### Searching
The Blazor File Manager component contains built-in searching functionality that allows you to search for and access a file or folder in the current path and its child folders.
### Moving files and folders with drag and drop
Files and folders can be moved within the file system by dragging and dropping them. [Drag-and-drop](https://blazor.syncfusion.com/documentation/file-manager/drag-and-drop?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples) support can be turned on or off in the Blazor File Manager.
### Access control restriction
The Blazor File Manager provides support to restrict access to files and folders by defining a set of rules for them. Only authorized users will be able to access them.
### Restrict file types on upload
You can specify the types of files that can be uploaded in the Blazor File Manager. Other file types will be restricted on upload.
### Multiple-file selection
The Blazor File Manager component has built-in support for the selection of multiple files or folders. [Multiple-file selection](https://blazor.syncfusion.com/documentation/file-manager/multiple-file-selection?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples) will be effective when a single operation like download or delete is performed over multiple files in the file system.
### Quick access menu
The Blazor File Manager component has context menu support to list the operations to be performed with the files and folders. It appears when a file or folder is right-clicked. The context menu items can be customized according to user preference.
### Localization
The text of a context menu list and the tooltips being displayed in the user interface can be localized to any supported language. The Blazor File Manager component uses a localization library (l10) to localize the text values.
### Web accessibility
* Follows [WAI-ARIA](https://www.w3.org/WAI/ARIA/apg/?utm_campaign=javascript-file-manager-github-samples&utm_medium=listing&utm_source=github) best practices for implementing keyboard interaction.
* Supports right-to-left (RTL) direction for users working in right-to-left languages like Hebrew and Arabic.
### Built-in themes
The Blazor File Manager layout supports several built-in themes: Material, Bootstrap, Fabric (Office 365), and high contrast. Users can customize any one of these built-in themes or create new themes to achieve their own desired look by either simply overriding the SASS variables or using our Theme Studio application.
### Developer-friendly APIs
Developers have control over all the UI elements and behaviors of the components to provide the best experience to end users with a rich set of developer-friendly APIs.

## Prerequisites
Ensure the following requirements are met before running this project:
- Visual Studio 2022 or later
- .NET SDK compatible with Blazor Server
- Syncfusion Blazor packages
- Valid Syncfusion license key (if required)

## Installation
1. Clone or download this repository to your local machine.
2. Open the solution file using **Visual Studio 2022**.
3. Restore the NuGet packages by rebuilding the solution.

## Usage
After running the application, the Blazor File Manager is displayed with a toolbar, navigation pane, and content pane. Users can browse folders, manage files, and perform common file system operations directly from the web interface.

This sample demonstrates how users can:
- Navigate through folder structures
- Upload and download files
- Sort and search files
- Perform drag‑and‑drop operations
- Manage access permissions

## Configuration
The File Manager configuration is handled within the Blazor Server application. You can customize:
- Toolbar items and commands
- Visibility of navigation and content panes
- Allowed file types for upload
- Access control rules
- Localization and theme settings

## Documentation
- **General Syncfusion documentation:**  
  https://help.syncfusion.com/
- **Blazor Introduction:**  
  https://blazor.syncfusion.com/documentation/introduction
- **Blazor File Manager – Getting Started:**  
  https://blazor.syncfusion.com/documentation/file-manager/getting-started-with-web-app

## Related links

* [Learn More about Blazor File Manager](https://www.syncfusion.com/blazor-components/blazor-file-manager?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)
* [Download Free Trial](https://www.syncfusion.com/downloads?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)
* [Pricing](https://www.syncfusion.com/sales/pricing?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)
* [Documentation](https://blazor.syncfusion.com/documentation/file-manager/getting-started-with-web-app?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)
* [Online Examples](https://blazor.syncfusion.com/demos/file-manager/overview?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples&theme=bootstrap5)
* [Community Forums](https://www.syncfusion.com/forums/blazor-components)
* [Suggest a Feature](https://www.syncfusion.com/feedback/blazor-components)

## Troubleshooting
- Ensure that the Syncfusion license key is registered correctly.
- Verify that all required NuGet packages are restored.
- Rebuild and restart the project if UI changes are not reflected.
- Check application logs for runtime or configuration errors.

## Support
For detailed API references, configuration guidance, and advanced usage scenarios, refer to the Syncfusion Blazor File Manager documentation links provided above.

## About Syncfusion Blazor Components

Syncfusion's [Blazor components](https://www.syncfusion.com/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples) library offers over 155 UI components to work with Blazor server-side and client-side (Blazor WebAssembly) projects seamlessly. In addition to File Manager, we provide popular Blazor components such as [DataGrid](https://www.syncfusion.com/blazor-components/blazor-datagrid?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [Charts](https://www.syncfusion.com/blazor-components/blazor-charts?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [Scheduler](https://www.syncfusion.com/blazor-components/blazor-scheduler?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [Diagram](https://www.syncfusion.com/blazor-components/blazor-diagram?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), and [DOCX Editor](https://www.syncfusion.com/docx-editor-sdk/blazor-docx-editor?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples).

## About Syncfusion

Founded in 2001 and headquartered in Research Triangle Park, N.C., Syncfusion has more than 38,000 customers and more than 1 million users, including large financial institutions, Fortune 500 companies, and global IT consultancies.

Today, we provide 1600+ controls and frameworks for web ([Blazor](https://www.syncfusion.com/blazor-components?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [ASP.NET Core](https://www.syncfusion.com/aspnet-core-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [ASP.NET MVC](https://www.syncfusion.com/aspnet-mvc-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [ASP.NET WebForms](https://www.syncfusion.com/jquery/aspnet-webforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [Angular](https://www.syncfusion.com/angular-components?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [React](https://www.syncfusion.com/react-components?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), [Vue](https://www.syncfusion.com/vue-components?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples), and [Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)),
mobile
([Xamarin](https://www.syncfusion.com/xamarin-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples),
[Flutter](https://www.syncfusion.com/flutter-widgets?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples),
[UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples),
and
[JavaScript](https://www.syncfusion.com/javascript-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)),
and desktop development ([Windows
Forms](https://www.syncfusion.com/winforms-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples),
[WPF](https://www.syncfusion.com/wpf-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples),
[WinUI(Preview)](https://www.syncfusion.com/winui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)
and
[UWP](https://www.syncfusion.com/uwp-ui-controls?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples)).
We provide ready-to-deploy enterprise software for dashboards, reports,
data integration, and big data processing. Many customers have saved
millions in licensing fees by deploying our software.

		
<hr style="height:0.3px;border:none;color:lightgrey;background-color:lightgrey;" />

<p align="center">
  <a href="mailto:sales@syncfusion.com?Subject=Syncfusion Blazor File Manager - Github" target="_top">sales@syncfusion.com</a> | <a href="https://www.syncfusion.com?utm_source=github&utm_medium=listing&utm_campaign=javascript-file-manager-github-samples">www.syncfusion.com</a> | 1-888-9 DOTNET <br>
</p>




