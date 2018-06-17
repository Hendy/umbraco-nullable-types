# Umbraco Nullable Types
Property editors which enable a null value to be selected in preference to a default value.

## _Nullable String_
'But strings are always nullable !' however with a textbox alone there's no way to distinguish between whitespace and null, 
so this data-type adds a checkbox to toggle between the textbox value and a null.

The raw values are stored as json, but will also read in raw string values (as stored by the built-in textstring data-type, so can migrate away from this, but not return if item has been saved).
The property-value-converter will return a string.


### Property Editor

![Property Editor Example](docs/NullableStringPropertyEditor.png)
    
### Property Editor Configuration

![Property Editor Configuration Example](docs/NullableStringPropertyEditorConfiguration.png)


## _Nullable Boolean_
A tri-state data-type where the default value is null.

The raw values are stored as strings: "", "0" or "1", which makes it compatable with the built-in true/false data-type.
The property-value-converter will return a nullable bool.

### Property Editor

![Property Editor Example](docs/NullableBooleanPropertyEditor.png)
    
### Property Editor Configuration

![Property Editor Configuration Example](docs/NullableBooleanPropertyEditorConfiguration.png)

