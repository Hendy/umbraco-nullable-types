# Umbraco Nullable Types
Data-types for bool? string? and int?

## Data Types
* Nullable Boolean
A tri-state data-type where the default value is null.
The raw values stored are: "", "0" or "1" so compatable with the built-in true/false data-type.

* Nullable String
Extends the built in textstring data-type with a checkbox, enabling a null value (as opposed to empty string) to be specified.