﻿using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour {
	void Start () {
		LineRenderer renderer = gameObject.GetComponent<LineRenderer>();
		// 線の幅
		renderer.SetWidth(0.1f, 0.1f);
		// 頂点の数
		renderer.SetVertexCount(2);
		// 頂点を設定
		renderer.SetPosition(0, Vector3.zero);
		renderer.SetPosition(1, new Vector3(1f, 1f, 0f));
	}
	// Update is called once per frame
	void Update () {
	
	}
}
