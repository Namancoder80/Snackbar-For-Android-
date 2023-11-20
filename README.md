# SnackbarApi

![Snackbar](https://github.com/Namancoder80/Snackbar-For-Android-/assets/96739382/849d6c30-3b0c-405f-a4fd-5e10a00842ac)

`SnackbarApi` is a Unity script that provides a simple way to display snackbar notifications with customizable themes. Users can easily integrate this script into their Unity projects and create different themes to match their app's design.

## Features

- **Customizable Themes**: Users can create different themes for the snackbar using the `SnackbarTheme` scriptable object.
- **Easy Integration**: Integrate the snackbar into your Unity project with minimal effort.
- **Singleton Pattern**: Implemented as a singleton to ensure only one instance exists.

## Installation

1. Download the latest release from the [Releases](https://github.com/YourUsername/YourRepository/releases) page.
2. Import the package into your Unity project.

## Usage

1. Attach the `SnackbarApi` script to a GameObject in your Unity scene.
2. Create different themes using the `SnackbarTheme` scriptable object.
3. Call the snackbar from your code using:

```csharp
SnackbarApi.Instance.ShowSnackbar("Your message here", "Button Text", () => {
    // Action to perform when the button is clicked
    GetAction();
});
// Creating a SnackbarTheme
[CreateAssetMenu(fileName = "LightMode", menuName = "YourName/Snackbar/Themes")]
public class SnackbarTheme : ScriptableObject {
    public Color BackgroundColor;
    public Color MessageColor;
    public Color ButtonColor;
    public Color IconColor;
}

// Showing a snackbar
SnackbarApi.Instance.ShowSnackbar("Dear user, the action you have performed is invalid", "Try Again", () => {
    GetAction();
});
Contributing
If you'd like to contribute to this project, feel free to fork the repository and submit a pull request.
![Themes](https://github.com/Namancoder80/Snackbar-For-Android-/assets/96739382/a1604452-9da1-47e3-a602-eb1b4db51414)
