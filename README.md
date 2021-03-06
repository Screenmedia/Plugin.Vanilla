# Screenmedia Vanilla Plugin Template
[![Build status](https://screenmedia.visualstudio.com/Mobile/_apis/build/status/Vanilla%20Plugin)](https://screenmedia.visualstudio.com/Mobile/_build/latest?definitionId=74)

Use this as a starting point for creating a plugin. This template is a xamarin plugin but the folder structure should be universal. This Plugin creates an ice cream machine that dispenses different flavours based on the platform.

### Setup
* Install this plugin in the Core and Platform projects.

**Platform Support**

|Platform|Supported|Version|
| ------------------- | :-----------: | :------------------: |
|Xamarin.iOS|Yes|iOS 6+|
|Xamarin.Android|Yes|API 10+|
|Windows Phone RT|No||
|Windows Store RT|No||
|Windows 10 UWP|No||
|Xamarin.Mac|No||


### API Usage
```csharp
public interface IIceCreamMachine
{
	// returns the ice cream
	string Dispense();
}
```

### Usage
* Resolve the Ice Cream Machine
* Call Dispense() to get the Ice Cream for that platform
```csharp
IIceCreamMachine iceCreamMachine = CrossIceCreamMachine.Current;
var iceCreamFlavour = iceCreamMachine.Dispense();
```


Moar Plugins!!!
Moar Shared Code!!!
Moar Awesome Apps!!!
