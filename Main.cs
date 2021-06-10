using Godot;
using System;

public class Main : Node
{
    // Declare member variables here. Examples:
    [Export]
    public PackedScene Mob;
    private int _score;
    private Random _random = new Random();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        
    }

    private float RandRange(float min, float max)
    {
        return (float) _random.NextDouble() * (max - min) + min;
    }

//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
