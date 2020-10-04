# Contribution guidelines

First of all, thank you for thinking of contributing to this project 😄

Before sending a Pull Request, consider making an issue in the repository and assigning it to yourself.

## Development

You need to clone the repository and restore packages.
Navigate to the **src/WaybackMachine.DotNet.Client** folder and run the following command.

```
dotnet restore
```

After the packages have been restored, you can run the application.

```
dotnet run
```

Now you are ready to add features to the component.
The project is bootstrapped with [create-react-library](https://github.com/transitive-bullshit/create-react-library) and TypeScript has been added to the project. You can read more about the development workflow in the [project docs](https://github.com/transitive-bullshit/create-react-library).

Run npm start in both the main directory and the example directory in two separate terminals.
This way you will be able to see your changes on the example page when changes are made to the component.

```bash
npm start
```