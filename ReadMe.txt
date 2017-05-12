Github Link:
======================================================================================
https://github.com/nagorinikhil/AVRFinalProject.git

Project Requirement:
======================================================================================
1. Unity 5.6 or grater 
(Assumption, Microsoft Visual studio installed with Unity or already installed)
2. Oculus rift
3. Leap motion

How to open in Unity:
======================================================================================
1. File-> OpenProject-> select root directory of the folder

Module Description:
======================================================================================
***********************Note: Please ignore .meta files *****************************

Object Assest Files: 	
	Assets/LeapMotionModule/Ball.prefab
	Assets/LeapMotionModule/RingBoard.prefab
Unity Scenes: Assets/_Scene/*
	
LeapMotion Integration: 
	Assets/LeapMotionModule/InterationEngine/InteractionManager.prefab
	Assets/LeapMotionModule/UIInput/Prefabs/LeapEventSystem.prfab
	Assets/LeapMotion/Prefabs/LMHeadMountedRig.prefab

	Internal Scripts used by LeapMotion Module:
		Assets/LeapMotionModule/InterationEngine/InteractionBehaviour.cs
		Assets/LeapMotionModule/InterationEngine/InteractionManager.cs
		Assets/LeapMotionModule/InterationEngine/InteractionMaterial.cs
		
C# scripts: 
		Assets/Scripts/BallBounceSound.cs
		Assets/Scripts/BallGeneration.cs
		Assets/Scripts/DetectScoring.cs
		Assets/Scripts/GameOverScoreDisplay.cs
		Assets/Scripts/LevelManager.cs
		Assets/Scripts/PrimaryTrigger.cs
		Assets/Scripts/ScoreDisplay.cs
		Assets/Scripts/ScoreAbsorber.cs
		Assets/Scripts/ScoreKeeper.cs
		Assets/Scripts/SecondaryTrigger.cs
		Assets/Scripts/TimeRemainingDisplay.cs
		
Audio files: Assets/AudioKit/*
Image Files: Assets/Images/*

Instruction to play:
======================================================================================
1. Open the project in unity
2. Select Assets/_Scene/ Folder
3. Select 01_Menu scene
4. Click on play button
5. Enjoy


























