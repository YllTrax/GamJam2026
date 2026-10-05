using Godot;
using System;

public partial class WitchBody : Area2D
{
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
		AreaEntered += OnAreaEntered;
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
	}
	
	 private void OnAreaEntered(Area2D area)
	{
		if (area is PumpkinBodyLv1)
		{
			GetParent().QueueFree();
		}
	}
}
