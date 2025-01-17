# CMPM163Labs
Labs for CMPM163

LAB 8
---------------------------------------------------------------------------------------------------------
Reference City: City Night in Seoul, Korea
![](images/Lab8_KoreaCity.jpg)

My City:
![](images/Lab8_MyCity.jpg)

Explanation: I used the free assets from the unity asset store and tutorial to create my procedural city. Using the tutorial, I adjusted some of the properties of the Perlin Noise so the buildings shown in the front are relatively smaller than the ones in the back. Many of the smaller buildings in Korea have the same architectural design and size.  Since there was a limited amount of assets I could use, I had to adjust the some of the prefabs to make them look more like skyscrappers like in the reference photo. I also adjusted the Quaternion rotations of the prefabs so the buildings are facing similar to the ones in the reference photo. What really inspired me to generate this city was the night lights produced by the buildings and streets. In order to do this I added some point lights to some of the prefabs and street roads and adjusted the properties for the directional light. I also found a new skybox from the unity asset store and used that to make a more night feeling sky. 

Partner Section: I was not able to come in contact with my partner


LAB 7
---------------------------------------------------------------------------------------------------------
Google Drive Link: 
https://drive.google.com/file/d/1dOtxdL0b9LeQaf5-CpshspAIuNYpNg2R/view?usp=sharing

For the mountain terrain scene I used the video from the tutorial and adjusted some elements within the shader graph. I adjusted the voronoi inputs and outputs from the position nodes by multiply it to y vertex position. For the water motion waves, I used the video provided in the tutorial and shader programming to create the vertex displacements. I adjusted the properties (color, strength, and speed) to make it fit more for my scene. In the creative portion, I found some free tree, rocks, and skybox assets from the unity asset store and used those to create an enviorment. The campfire and logs were created within unity used 3D cube objects. The fire was created by using unity's particles effects. I also tweaked a little of the lighting. 

Partner Section: 
I was not able to reach my partner for this section.



LAB 6
---------------------------------------------------------------------------------------------------------
Unity Scene Screenshot
![](images/CMPM163_Lab6_ss.jpg)

Lighting Overview and Lights:

Spotlight: A light that is casted within a cone shade boundary. The light rays that are casted are pointed within the direction of the              cone shade
Directional Light: Ray light that is casted through a single direction through the whole environment (I like to think of it as the sun                      of the scene's world).
Point Light: Light that is casted in every direction from the center point of the light material. 
Area Light: A light source that can only be used with baked lighting (so static game objects). The light that is casted is within a                 rectangular boundary and is casted within these boundaries.

Material & The Standard Shader:

For this material, I used a texture pack from https://3dtextures.me/2018/10/29/leather-006/ to obtain the leather look for the basketball and adjusted the albedo map and normal map for the texture to fit the colors. I then found a basketball wrap to cover the sphere and adjust some properties to make the leather feel stick out.
![](images/basketball_reference.jpg) 
![](images/unitymaterial.png)

Texture:
For the two texture I created a brick wall and concrete flooring. I found the textures and normal maps froms
Brick: https://3dtextures.me/2018/12/03/brick-wall-015/
Concrete: https://3dtextures.me/2018/12/04/concrete-012/
For the brick wall I added it to the material in the scene and fixed the tiling and colors of the texture before implementing
For the concrete flooring, I implemented the textures onto the scene by using the normal map and color packs that it provided. I also adjusted a few properties to make the concrete more apparent.

Skybox:
For the skybox, I found a free skybox texture set from the Unity Asset store named "Skybox" and created a skybox out of the materials the pack provided.

LAB 5
---------------------------------------------------------------------------------------------------------
Lab 5 (part 1) Google Drive Link:
https://drive.google.com/file/d/1JPPqzvkbuJcaKrF0rbgi9KtAIlsyaUgW/view?usp=sharing

For the modification for the karting game: 
I added an additional smoke particle effect to the exhaust for the kart. 
I also modified and changed the current sky-box in the scene with another skybox found in the unity asset store. New skybox has a blue sky and white clouds.
For enviormental changes, I changed the track up adding more track prefabs along with a curve-up and curve-down ramp with two additional check points. I also added speed boost around the map after every checkpoint. I added a ramp where the player would accelerate up and land while crashing onto the bowling pins. Addtional directional lighting and buildings were also added to make it feel more of a city.


LAB 4
---------------------------------------------------------------------------------------------------------
Lab 4 Google Drive Link
https://drive.google.com/file/d/19GNRYjDjWFQGToirw-Jqs9vWbrAPL2rK/view?usp=sharing

Question 24 answers:
a. x = u * 7
b. y = (7 - 7v)
c. (2.625, 5.25) Color = gray.

Cube Explanations: Starting from the left

Cube1: Texture A. Followed the tutorial and built the cube using THREE.js built in texture functionality. Used texture "197.jpg"

Cube2: Texture A & Normal Map A. Followed the tutorial and built the cube using THREE.js texture functionality Used texture "197.jpg" and "197_norm.jpg"

Cube3: Texture B & Normal Map B. Used a new texture "161b.jpg" and a new normal map "161_norm.jpg". Created a new material1 variable that uses the THREE.js functionality to create a new mesh with the texture and normal map and implemented it onto the cube.

Cube4: Texture C. Followed the tutorial and implemented a new texture "172.jpg" with shaders and implemented this shader onto the cube.

Cube5: Texture D. Created a new fragment script "fragmentShader1.frag" and used a new visible texture "176.jpg," (2x2 grid).
In this new fragment script, I checked if the (x,y) coordinates of the grid were within the sample size of 1. If not then I would change the values until the (x,y) values of the UV coordinates were within the sample size.
Values with UV coordinates less than 0.5 which was the half of the sample size of 1 had their values multiplied by 2.0 to fit into the sample size
Values with UV coordinates greater than 0.5 had their values multiplied by 2.0 then subtracted by 1.0 to fit into the sample size
Values with x values greater than 0.5 had their values multiplied by 2.0 then subtracted by 1.0 and y values less than 0.5 were multiplied by 2.0.
Values with y values greater than 0.5 had their values multiplied by 2.0 then subtracted by 1.0 and x values less than 0.5 were multiplied by 2.0.

LAB 3
---------------------------------------------------------------------------------------
lab 3 Google Drive Video link
https://drive.google.com/file/d/1WvPc6M8OcPRab9Oy0QqxYMW6GfOtagq2/view?usp=sharing

Explanations: 
For the first cube starting from the left I used a new three.js material called THREE.MeshToonMaterial. For the material I also adjusted some proporties giving a bumpScale of 5, color changes, and a few tweaks in the specular and shiniess properites.

The second cube was made from the tutorial from Lab3 using the Phong material from Three.js.

The third cube was made from the tutorial from lab3 using vertex and fragment scripts to generate a custom shader.

For the forth cube I created a new fragment scripted name fragmentShader1.frag and created four new uniform vector3 colors. To start off I mixed two shades of colors Perano and Lightpink, then mixed this color was dark violet, and lastly added lavender into the mix. Once the colors were generated and mixed. I created a cube and added the custom ShaderMaterial onto the cube.




LAB 2
---------------------------------------------------------------------------------------
Part 1 Google Drive link 
https://drive.google.com/file/d/1L-w4AJihAWRspWG8ojld5iulsIqTSHeW/view?usp=sharing

Part 2 Image Screenshot
![](images/part2_image.png)

