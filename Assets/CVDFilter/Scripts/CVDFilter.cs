﻿using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[ExecuteInEditMode]
[DisallowMultipleComponent]
[RequireComponent(typeof(PostProcessVolume))]
public class CVDFilter : MonoBehaviour {
	enum ColorType { Normal, Protanopia, Protanomaly, Deuteranopia, Deuteranomaly, Tritanopia, Tritanomaly, Achromatopsia, Achromatomaly }

	[SerializeField] ColorType visionType = ColorType.Normal;
	ColorType currentVisionType;
	PostProcessProfile[] profiles;
	PostProcessVolume postProcessVolume;

	void Start () {
		currentVisionType = visionType;
		gameObject.layer = LayerMask.NameToLayer("CVDFilter");
		SetupVolume();
		LoadProfiles();
		ChangeProfile();
	}

	void Update () {
		if (visionType != currentVisionType) {
			currentVisionType = visionType;
			ChangeProfile();
		}
	}

	void SetupVolume () {
		postProcessVolume = GetComponent<PostProcessVolume>();
		postProcessVolume.isGlobal = true;
	}

	void LoadProfiles () {
		Object[] profileObjects = Resources.LoadAll("", typeof(PostProcessProfile));
		profiles = new PostProcessProfile[profileObjects.Length];
		for (int i = 0; i < profileObjects.Length; i++) {
			profiles[i] = (PostProcessProfile)profileObjects[i];
		}
	}

	void ChangeProfile () {
		postProcessVolume.profile = profiles[(int)currentVisionType];
	}

	public void OnPressedAchromatomaly()
	{
		visionType = ColorType.Achromatomaly;
	}
	public void OnPressedAchromatopsia()
	{
		visionType = ColorType.Achromatopsia;
	}
	public void OnPressedTritanomaly()
	{
		visionType = ColorType.Tritanomaly;
	}
	public void OnPressedTritanopia()
	{
		visionType = ColorType.Tritanopia;
	}
	public void OnPressedDeuteranomaly()
	{
		visionType = ColorType.Deuteranomaly;
	}
	public void OnPressedDeuteranopia()
	{
		visionType = ColorType.Deuteranopia;
	}
	public void OnPressedProtanomaly()
	{
		visionType = ColorType.Protanomaly;
	}
	public void OnPressedProtanopia()
	{
		visionType = ColorType.Protanopia;
	}
	public void OnPressedNormal()
	{
		visionType = ColorType.Normal;
	}
}
