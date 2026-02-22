Vin
===

![Logo](resources/logo.svg)

[![Static Badge](https://img.shields.io/badge/Wikipedia-Vehicle_identification_number-blue?label=Wikipedia&link=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FVehicle_identification_number)](https://en.wikipedia.org/wiki/Vehicle_identification_number)

A value type (struct) for representing a **vehicle identification number** (chassis number or frame number)

[![NuGet Version](https://img.shields.io/nuget/v/Skaar.Vin.svg)](https://www.nuget.org/packages/Skaar.Vin)

Use `Parse` or `TryParse` to create a `Vin` instance from a string.
You can also use implicit conversion from `string` to `Vin`:

```csharp
var vin = (Vin) "3N1CE2CP0EL431597"
```
Value serializes to and deserializes from JSON using `System.Text.Json`.
In json, it is represented as a string.

Validation is only done by ensuring that the string is 17 characters long.
The letters I, O, or Q are converted to 1, 0 and 0.

## Properties and methods

- `IsValid`: returns true if the length is 17.
- `GeographicArea`: Returns the area indicated by the first character of the VIN.
- `Country`: Returns the country indicated by the first character of the VIN.
- `Manufacturer`: Returns the manufacturer indicated by VIN.
- `ModelYear`: Returns the model year indicated by the 10th character of the VIN. European vehicles will return `null`.
- `PlantCode`: Returns the plant code for American and Chinese vehicles.
- `ToString()`: returns the VIN as a string.

Accessing these properties may cause memory allocations.