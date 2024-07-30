# Ball Maze : Finding the path (Mobile)
## Description
1 trái banh lăn trong 1 mê cung, trái banh sẽ cố gắng tìm lối thoát ra mê cung ấy.
## Game Requirement
### Di chuyển của trái banh
Trái banh sẽ di chuyển theo khuynh hướng vật lí và áp dụng phương thức vật lí của Unity (AddForce, RigidBody, etc.)
_ Hệ thống User Input là 1 Joystick (Là 1 Singleton), khi start game, lấy Direction của Joystick làm hướng của nhân vật (trái banh).
- Ball sẽ phải move theo Direction Joystick của người chơi (Direction).
- Tốc độ lăn của ball cũng sẽ bị ảnh hưởng bởi Direction của user.
- Di chuyển nếu thông qua Update Loop thì loop sẽ phải là FixedUpdate (research để hiểu hơn tại sao dùng fixed update khi xử lí vật lí), time frame thì phải là fixedDeltaTime.
