# Ball Maze : Finding the path (Mobile)
## Description
1 trái banh lăn trong 1 mê cung, trái banh sẽ cố gắng tìm lối thoát ra mê cung ấy.
## Game Requirement
### Di chuyển của trái banh
Tạo script InputController là 1 Singleton, là nơi nhận vào input của User thông qua Joystick và trả về 1 vector hướng di chuyển thông qua delegate (Action) (Ref: [Joystick Pack](https://assetstore.unity.com/packages/tools/input-management/joystick-pack-107631) )
Trái banh sẽ di chuyển theo khuynh hướng vật lí và áp dụng phương thức vật lí của Unity (AddForce, RigidBody, etc.)
- Ball sẽ phải move theo Direction người chơi hướng về.
- Di chuyển nếu thông qua Update Loop thì loop sẽ phải là FixedUpdate (research để hiểu hơn tại sao dùng fixed update khi xử lí vật lí), time frame thì phải là fixedDeltaTime.
