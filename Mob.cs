using Godot;
using System;

public class Mob : RigidBody2D
{
    
    [Export]
    public int minSpeed = 250;

    [Export]
    public int maxSpeed = 350;

    static private Random _random = new Random();

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        var animatedSprite = GetNode<AnimatedSprite>("AnimatedSprite");
        var mobTypes = animatedSprite.Frames.GetAnimationNames();
        animatedSprite.Animation = mobTypes[_random.Next(0, mobTypes.Length)];

    }

    public void OnScreenExited()
    {
        QueueFree();
    }
//  // Called every frame. 'delta' is the elapsed time since the previous frame.
//  public override void _Process(float delta)
//  {
//      
//  }
}
