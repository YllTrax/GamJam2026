using Godot;
using System;

public partial class Pumpkin : Node2D
{
	[Export] public Node2D Cible;
	[Export] public float Vitesse = 200f;
	
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		if (IsInstanceValid(Cible))
		{
			GlobalPosition = GlobalPosition.MoveToward(Cible.GlobalPosition, Vitesse * (float)delta);
		}
	}
}
