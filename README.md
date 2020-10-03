<div align="center">
  <img 
    src="https://github.com/kristofferandreasen/wayback-machine-csharp-sdk/blob/master/nuget-images/logo.png?raw=true"  alt="Wayback Machine C# .NET Core SDK/Client"
  />
  <h1>💾 Wayback Machine C# .NET Core SDK 💾</h1>
</div>
<div align="center">
  This API wrapper is built to make it easier to use the Wayback Machine API from Internet Archive.
  It provides a simple interface to get snapshots from websites back in time.
</div>

<br />

<div align="center">
  <a href="https://github.com/kristofferandreasen/wayback-machine-csharp-sdk/actions">
    <img src="https://github.com/kristofferandreasen/wayback-machine-csharp-sdk/workflows/mainworkflow/badge.svg"
      alt="Build status" />
  </a>
  <a href="https://standardjs.com">
    <img src="https://img.shields.io/badge/code_style-standard-brightgreen.svg"
      alt="Standard" />
  </a>
</div>

<div align="center">
  <h3>
    <a href="https://www.nuget.org/packages/WaybackMachineCsharpSdk/">
      NuGet Package Download
    </a>
    <span> | </span>
    <a href="https://github.com/kristofferandreasen/wayback-machine-csharp-sdk#contributing">
      Contributing
    </a>
    <span> | </span>
    <a href="https://archive.org/help/wayback_api.php">
      API Documentation
    </a>
  </h3>
</div>

<div align="center">
  <sub>A simple C# SDK for the Wayback Machine API. Built with ❤︎ by
  <a href="https://github.com/kristofferandreasen">Kristoffer Andreasen</a>
</div>

## Installation

You need to install the NuGet Package to use the library.

### Install with Package Manager

```
Install-Package WaybackMachineCsharpSdk
```

With version:

```
Install-Package WaybackMachineCsharpSdk -Version 1.0.0
```

### Install with .NET CLI

```
dotnet add package WaybackMachineCsharpSdk
```

With version:

```
dotnet add package WaybackMachineCsharpSdk --version 1.0.0
```

## Using the library

The easiest way to use the library is by using dependency injection.
In the following sections you can see the easiest ways to use the library.

### Dependency Injection: .NET Core Web Application

* Register the WaybackMachineCsharpSdk interface in the startup file
* Inject the service in the class where you want to use it

### Dependency Injection: Azure Function

The pattern for using dependency injection in an Azure Function is similar to a web application.

* Create a startup.cs file to enable dependency injection
* Register the WaybackMachineCsharpSdk interface in the startup file
* Inject the service in the class where you want to use it

## Developing

The project is developed as a .NET Core Class Library.
The current framework version used is .NET Core 3.1.

To start developing, you need to clone the repo on your local workstation.

#### Restore Dependencies

```
dotnet restore
```

#### Run Project

```
dotnet run
```

#### Test Project

The project is using XUnit for testing.

```
dotnet test
```

This will start up the development server allowing you to see the results.
Be aware that the solution is setting a cookie and this cookie will be stored in your browser.
In order to see the banner again, you will need to open the localhost link in incognito or clear your browser cookies.

## Contributing

Your contributions are always welcome!
Please have a look at the [contribution guidelines](https://github.com/kristofferandreasen/wayback-machine-csharp-sdk/blob/master/CONTRIBUTING.md) first 🎉

## License

MIT © [kristofferandreasen](https://github.com/kristofferandreasen)