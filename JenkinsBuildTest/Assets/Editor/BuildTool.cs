using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class BuildTool {
  // ビルド実行でAndroidのapkを作成する
  [UnityEditor.MenuItem("Tools/Build/Android")]
  public static void BuildAndroid() {
//	EditorUserBuildSettings.SwitchActiveBuildTarget( BuildTarget.Android );
//	List<string> allScene = new List<string>();
//	foreach( EditorBuildSettingsScene scene in EditorBuildSettings.scenes ){
//	  if (scene.enabled) {
//		allScene.Add (scene.path);
//	  }
//	}   
//	PlayerSettings.bundleIdentifier = "com.tayutau";
//	PlayerSettings.statusBarHidden = true;
//	BuildPipeline.BuildPlayer( 
//	  allScene.ToArray(),
//	  "newgame.apk",
//	  BuildTarget.Android,
//	  BuildOptions.None
//	);
	Debug.Log("実行");
  }
}