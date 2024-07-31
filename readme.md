# UI Buttons in Unity

This Unity project demonstrates how to implement interactive buttons both in UI and on 3D game objects. It covers various aspects of button functionality, including animations, event handling, and integration with 3D environments.

## Project Overview

This project showcases:
- Standard UI buttons with interactive animations.
- 3D game object buttons with similar interactive animations and event handling.
- Techniques to integrate UI button functionality with 3D objects.

## Features

- **Interactive Animations**: Buttons change states (Normal, Highlighted, Pressed, Disabled) with animations.
- **Event Handling**: Buttons trigger events on click, including toggling states and invoking UnityEvents.
- **3D Integration**: How to make 3D game objects act like UI buttons using Unity's built-in components.

## Getting Started

### Prerequisites

- Unity 2022.3.39f1 or later
- Basic knowledge of C# and Unity

### Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/hsuehyt/uiButtons.git
    ```
2. Open the project in Unity:
    - Launch Unity Hub.
    - Click on "Add".
    - Navigate to the folder where you cloned the repository and select it.

### Usage

1. Open the scene `Assets\0730\uiButtons` to see the demonstration of both UI buttons and 3D game object buttons.
2. Play the scene to interact with the buttons and observe their behaviors.

### Key Components

- **UI Button**: Standard Unity UI button with animations and event handling.
- **3D Button**: Custom implementation using Unity's `Selectable` class and `Animator` to handle 3D game object interactions.

### Custom 3D Button Setup

For creating a 3D button:
1. Create a 3D game object.
2. Attach a collider (e.g., BoxCollider).
3. Attach an `Animator` component and set up the animation controller with states and triggers.
4. Attach the custom `MakeItButton` script.
5. Add a `PhysicsRaycaster` to the main camera to detect 3D interactions.

### Simplified Method for 3D Buttons

To quickly apply UI button functionality to 3D game objects:
1. Use the default button component from Unity's UI package.
2. Add a `PhysicsRaycaster` to the main camera.