# Blazor Server DataGrid - Globalization with CLDR Files

This is demo application to load the translation json files and CLDR data files to apply formats and translations based on the specified culture.

> This sample is created in **.NET Core 3.0 Preview 8**.

## Overview

This sample shows how to integrate the DataGrid component into a Blazor Server application with full globalization support. The application demonstrates loading locale-specific translation files and CLDR data to dynamically apply number formats, date formats, currency formats, and timezone information based on the selected culture.

### Key Implementation

The sample loads German (de) culture data and applies it to a DataGrid component that displays order information with proper localization:

- Order dates formatted according to German locale preferences
- Currency values formatted as EUR with German number formatting
- Column headers and UI elements translated to German
- All text and localization strings managed through JSON files

## Features

- **Full Globalization Support** - Load and apply culture-specific CLDR data and translations
- **Multiple Locale Files** - Support for various calendar systems, currency formats, and timezone data
- **Responsive DataGrid** - Blazor Server component with paging, sorting, and grouping capabilities  
- **Dynamic Culture Switching** - Change localization at runtime with JavaScript interop
- **CLDR Data Integration** - Comprehensive locale data for 100+ calendars, currencies, and regional formats

## Prerequisites

* [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
* [Visual Studio Code](https://code.visualstudio.com/)
* [.NET Core 3.0](https://dotnet.microsoft.com/en-us/download/dotnet/3.0)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/yourusername/EJ2-DataGrid-BlazorServer-Globalization-with-CLDR-Files-master.git
cd SynfusionTest
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore the NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors.
4. Run the project.

### Run with .NET CLI

```bash
# Restore dependencies
dotnet restore

# Run the project
dotnet run --project SynfusionTest/SynfusionTest.csproj
```

## References

**Documentation**: https://blazor.syncfusion.com/documentation/datagrid/global-local