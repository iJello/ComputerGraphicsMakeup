# ComputerGraphicsMakeup

## Reacreation of the scene

<img width="927" height="395" alt="image" src="https://github.com/user-attachments/assets/a60088a7-32cb-4f73-8e98-a1850ec9acf0" />  
Attempted to recreate the scene just before getting to the bridge with the statue

## Reflection Shader
<img width="727" height="497" alt="image" src="https://github.com/user-attachments/assets/0c8a2015-9c08-4923-a134-bae327370fbb" />  
how it works is that it uses the view direction and normal vector of the cubemap and a fresnel shader in order to only make it appear along the edges. I used a default base map as I didnt have any textures for   it, I made 2 significant changes compared to the one in class, I chose to create a new color called reflection color which changes the color of the reflection and I chose to output it to the emission channel   instead of the base color in order to make it not overpower the base texture. it suits the scene as the texture is supposed to be like a granite or marble which naturally has a sheen to it 

## Texture Tiling
<img width="977" height="487" alt="image" src="https://github.com/user-attachments/assets/fc4f82ce-8c95-434d-bc10-d9e598283ef9" />  
I started off with a kind of weird texture, I used the UV for the tiling offset to help tile it so that it gets stretched. In the game I imagined it as a kind of fleshy, muscle texture and the stretch sells it a lot better.

## Multiple UVs
 <img width="856" height="477" alt="image" src="https://github.com/user-attachments/assets/b81d89b7-5b72-45ed-82b4-052d4937189a" />  
 I used it to make the lava "move", I basically used the multiple uv channels to make it so that overtime it will switch textures, and hopefully create the illusion of movement on the lava. 

## General Shader
A basic shader using the default lighting in order to have a base default that works in general

## Custom Shader

<img width="575" height="256" alt="image" src="https://github.com/user-attachments/assets/2e251cd6-7185-478a-b5b2-b5ceac488634" />

 <img width="1072" height="461" alt="image" src="https://github.com/user-attachments/assets/01528918-0d5d-46b0-9e5f-41cce443025e" /> 
 This shader helps sell the idea of a sun very well as it is just a fresnel with its power boosted way up. setting it to the emission channel helps it emit light and truly feels like the sun is blasting your face.
