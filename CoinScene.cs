using Godot;
using System;

public partial class CoinScene : Area2D
{

  private void _OnBodyEntered(Node2D body)
  {
	if (body is Player)
	{
	  var playerScaleX = body.Scale.X;
	  var playerScaleY = body.Scale.Y;

	  body.Scale = new Vector2(playerScaleX + 0.1f, playerScaleY + 0.1f);

	  GD.Print("Player collected coin");

	}

	QueueFree();
  }

}
