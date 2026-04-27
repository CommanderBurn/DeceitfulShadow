// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class PortfolioProject : ModuleRules
{
	public PortfolioProject(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"PortfolioProject",
			"PortfolioProject/Variant_Platforming",
			"PortfolioProject/Variant_Platforming/Animation",
			"PortfolioProject/Variant_Combat",
			"PortfolioProject/Variant_Combat/AI",
			"PortfolioProject/Variant_Combat/Animation",
			"PortfolioProject/Variant_Combat/Gameplay",
			"PortfolioProject/Variant_Combat/Interfaces",
			"PortfolioProject/Variant_Combat/UI",
			"PortfolioProject/Variant_SideScrolling",
			"PortfolioProject/Variant_SideScrolling/AI",
			"PortfolioProject/Variant_SideScrolling/Gameplay",
			"PortfolioProject/Variant_SideScrolling/Interfaces",
			"PortfolioProject/Variant_SideScrolling/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
