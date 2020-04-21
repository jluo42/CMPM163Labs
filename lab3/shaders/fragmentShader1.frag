varying vec3 vUv;

uniform vec3 colorC;
uniform vec3 colorD;

uniform vec3 colorA;
uniform vec3 colorB;

void main() {
	vec3 color = mix(colorA, colorB, vUv.z);
	color = mix(color, colorD, vUv.z);
	color = mix(color, colorC, vUv.z);
	gl_FragColor = vec4(color, 1.0);
}