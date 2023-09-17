using Godot;
using System;

public partial class Player : CharacterBody2D
{
  public const float Speed = 300.0f;
  public const float JumpVelocity = -400.0f;

  // Get the gravity from the project settings to be synced with RigidBody nodes.
  public float gravity = ProjectSettings.GetSetting("physics/2d/default_gravity").AsSingle();

  public override void _PhysicsProcess(double delta)
  {
	Vector2 velocity = Velocity;

	velocity.X = 0;
	velocity.Y = 0;

	// Add the gravity.
	Vector2 direction = Input.GetVector("ui_left", "ui_right", "ui_up", "ui_down");

	if (direction.X != 0)
	{
	  velocity.X = direction.X * Speed;
	}
	if (direction.Y != 0)
	{
	  velocity.Y = direction.Y * Speed;
	}



	Velocity = velocity;
	MoveAndSlide();
  }
}
