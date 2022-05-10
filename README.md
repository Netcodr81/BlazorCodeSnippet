# BlazorCodeSnippet

## Overview
A problem when developing a Blazor component library arises when you want to document how to use the component library. For example, say you want to document how to use your HelloWorld component. You surround the component with ***code*** and ***pre*** tags expecting to see something like this:

```csharp
<HelloWorld Message="Hello World">
```
  
However, when you run your application you see this:
```
    Hello World
```
This is because Blazor's rendering engine ignores the ***code*** and ***pre*** tags and renders the component. This leaves developers with only one option to document their code, a bunch of ***span*** tags styled with css. BlazorCodeSnippet is aimed to alliviate this problem by giving developers a component that can be used to document their code. This component is a wrapper around the [highlight.js](https://highlightjs.org/) package and provides the style highlighting for 37 common languges. It comes with over 200 styles out of the box, however you can develop your own using the guide found here at the [Highlight.js Theme Guide](https://highlightjs.readthedocs.io/en/latest/theme-guide.html).

## How to install

### 1. Install the package
Install using the Package-Manager
```powershell
 Install-Package BlazorCodeSnippet
```

Using the DotNet CLI

```code
 dotnet add package BlazoredCodeSnippet
```

Or go to [nuget.org](https://www.nuget.org/) and search for ***BlazorCodeSnippet***

### 2. Register the required services in the ***Program.cs*** or ***Startup.cs*** class

```csharp
<!-- When adding to Program.cs -->

   builder.services.AddBlazorCodeSnippet():

<!-- When Adding to Startup.cs -->

   public void ConfigureServices(IServiceCollection services)
   {
     services.AddBlazorCodeSnippet();
   }
   
```

### 3. Add the following imports to your _imports.razor file

```csharp
@using BlazorCodeSnippets.Components
```

### 4. Add a link to the CSS stylesheet of your choice to the index.html file in BlazorWASM or the _Layout.cshtml in a BlazorServer app. Example:

```html
<link href="_content/BlazorCodeSnippets/css/BlazorSnippets/equilibrium-light.min.css" rel="stylesheet"/>

```

See a complete list of the available stylesheets here

## Usage

Component Properties
| Property | Value Type | What it's for | Example |
| -------- | ---------- | ------------- | ------- |
| SnippetFilePath | string | The path to the snippet starting off the wwwroot folder | "/example.txt"|
| AllowCopy | bool | Allows the user to copy the code snippet. The default value is false | true or false |
| Language | SnippetLanguage | The  language of your code snippet | SnippetLanguage.Razor |

1. Create a text or html file containing the snippet you want the component to render, for example codesnippet.txt.
2. Add the file to the wwwroot folder. For example, create a folder called snippets and place the file in it.
3. Add the ***BlazorCodeSnippet*** component to the page
```csharp
<BlazorCodeSnippet Language="SnippetLanguage.Razor" SnippetFilePath="/snippets/codesnippet.txt" AllowCopy="true"/>
```
A list of all the ***SnippetLanage*** enums can be found here




