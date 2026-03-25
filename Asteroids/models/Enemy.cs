using System.Numerics;
using AsteroidSharp.Models.Shapes;
using Raylib_CSharp.Colors;

namespace AsteroidSharp.Models;

class Enemy(Vector2 StartingPosition, Vector2 localDirection, float s, Color color)
{
    private Vector2 _position = StartingPosition;
    private Vector2 _heading = localDirection;
    private IShape _shape = new EnemyShape(new Vector2(10, 5), color, StartingPosition);
    private float _speed = s;
    private Queue<Bullet> _bullets = new();

    public void Navigate()
    {

    }

    public void DrawEnemy() => _shape.DrawShape();
    private void MoveEnemy() => _position += _heading * _speed;

    private void RotateEnemy(float radians) => _shape.RotateShape(_position, radians);

    private void EnemyShoot() => _bullets.Enqueue(new(_position, _heading, Color.Red, 10, true));

    public bool CheckCollision(Vector2[] boundaries) => _shape.Collision(boundaries);
}
