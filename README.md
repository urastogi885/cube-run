# Cube-Run
[![License](https://img.shields.io/badge/License-MIT-blue.svg)](https://github.com/urastogi885/cube-run/blob/master/LICENSE)

## Overview
A simple dodging game. Just move your cube sideways to avoid obstacles and reach the end.

<p align="center">
  <img src="https://github.com/urastogi885/cube-run/blob/master/images/game_play.gif">
  <br><b>Figure 1 - Level 1 of the game</b><br>
</p>

## Dependencies

- Unity
- C#

## Install Dependencies

- Install Unity from [here](https://unity3d.com/unity/qa/lts-releases). The project have been developed on the 2019.4.3
version.
- You can use any editor to edit the scripts in the game. I used [Visual Studio Code](https://code.visualstudio.com/download) 
because of the extensions and compatibility with Unity.

## Build

- Open your command line terminal and clone the repository to your Unity workspace:
````
cd <Path to Unity Workspace>
git clone https://github.com/urastogi885/cube-run
````
- Open the project using Unity
- Build and export the project to get an application file by going into ```` File -> Build Settings````
- A build settings window will pop-up
- Select the platform as ````PC, Mac & Linux Standalone````, then select your system type such as 
Windows or Mac.
- Select architecture as ````x86_64```` for a Windows 64-bit PC
- Click ````Build```` and select the location to save the game application file (It is better if you save all your 
builds in a separate ````build```` folder)
- You can also click ````Build and Run```` to immedaitely run the game after build and skip the step below
- Go into the folder where you saved the file in the previous step and run the ````CubeRun```` application file