<div align="center">
  💾 Wayback Machine C# .NET Core SDK 💾
</div>
<div align="center">
  This API wrapper is built to make it easier to use the Wayback Machine API from Internet Archive.
  It provides a simple interface to get snapshots from websites back in time.
</div>

<br />

<div align="center">
  <!-- NPM version -->
  <a href="https://www.npmjs.com/package/react-announcement">
    <img src="https://img.shields.io/npm/v/react-announcement.svg"
      alt="NPM version" />
  </a>
  <!-- Downloads -->
  <a href="https://www.npmjs.com/package/react-announcement">
    <img src="https://img.shields.io/npm/dt/react-announcement.svg"
      alt="Downloads" />
  </a>
  <!-- Standard -->
  <a href="https://standardjs.com">
    <img src="https://img.shields.io/badge/code_style-standard-brightgreen.svg"
      alt="Standard" />
  </a>
</div>

<div align="center">
  <h3>
    <a href="https://archive.org/help/wayback_api.php">
      API Documentation
    </a>
    <span> | </span>
    <a href="https://www.npmjs.com/package/react-announcement">
      NuGet Package Download
    </a>
    <span> | </span>
    <a href="https://github.com/kristofferandreasen/react-announcement#properties">
      Properties
    </a>
    <span> | </span>
    <a href="https://github.com/kristofferandreasen/react-announcement#contributing">
      Contributing
    </a>
  </h3>
</div>

<div align="center">
  <sub>A simple C# SDK for the Wayback Machine API. Built with ❤︎ by
  <a href="https://github.com/kristofferandreasen">Kristoffer Andreasen</a>
</div>

## Install

You

## Usage

Continue reading for information on usage of the SDK.

### With Dependency Injection

The easiest way to use the library is by using dependency injection.
In the following sections you can see the easiest ways to use the library.

#### Dependency Injection: .NET Core Web Application

* Register the WaybackMachineCsharpSdk interface in the startup file
* Inject the service in the class where you want to use it

#### Dependency Injection: Azure Function

The pattern for using dependency injection in an Azure Function is similar to a web application.

* Create a startup.cs file to enable dependency injection
* Register the WaybackMachineCsharpSdk interface in the startup file
* Inject the service in the class where you want to use it

## Developing

The project is bootstrapped with [create-react-library](https://github.com/transitive-bullshit/create-react-library) and TypeScript has been added to the project. You can read more about the development workflow in the [project docs](https://github.com/transitive-bullshit/create-react-library).

To start developing, you need to open two terminals.

In the first tab, run from the main directory:
```
npm start
```
This will activate rollup to watch for any changes to your src directory and build the dist everytime.

In another terminal, navigate to the example folder:
```
cd example
```
Then run:
```
npm install
```
and finally:
```
npm start
```

This will start up the development server allowing you to see the results.
Be aware that the solution is setting a cookie and this cookie will be stored in your browser.
In order to see the banner again, you will need to open the localhost link in incognito or clear your browser cookies.

## Contributing

Your contributions are always welcome!
Please have a look at the [contribution guidelines](https://github.com/kristofferandreasen/wayback-machine-csharp-sdk/blob/master/CONTRIBUTING.md) first 🎉

## License

MIT © [kristofferandreasen](https://github.com/kristofferandreasen)