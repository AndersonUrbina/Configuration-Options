# MicroBlog — Configuration with SiteOptions

## Overview

This project demonstrates how to configure an ASP.NET Core application using a strongly typed `SiteOptions` class and environment-specific configuration.

## Features

- Configurable site name displayed in the site layout.
- Comment form visibility controlled by the `EnableComments` setting.
- Default configuration in `appsettings.json`.
- Development-specific override in `appsettings.Development.json`.

## Configuration

The default settings in `appsettings.json` are:

- `SiteName`: `My Micro Blog`
- `EnableComments`: `false`

In Development, `appsettings.Development.json` overrides `EnableComments` to `true`. This makes the Leave Comment form visible when the application runs in the Development environment.

## Implementation

- `SiteOptions.cs` defines the strongly typed configuration options.
- `Program.cs` registers the `SiteOptions` section with the dependency injection system.
- `_Layout.cshtml` displays the configured site name.
- The post Details view displays the Leave Comment form only when `EnableComments` is enabled.

## How to Run

1. Open the solution in Visual Studio.
2. Restore NuGet packages if prompted.
3. Select the appropriate launch profile.
4. Run the application with **F5**.
5. Open a post's Details page to check whether the Leave Comment form is visible.

## Screenshots

### Development — comments enabled

<img src="screenshots/DE.png" alt="MicroBlog running with the Leave Comment form visible">

### Default configuration — comments disabled

<img src="screenshots/PE.png" alt="MicroBlog running with the Leave Comment form hidden">

## Technologies

- C#
- ASP.NET Core
- Razor Views
- JSON configuration
- Dependency injection and the Options pattern