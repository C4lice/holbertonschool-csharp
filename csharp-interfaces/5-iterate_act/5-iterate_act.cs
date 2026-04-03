using System;
using System.Collections.Generic;

public class RoomObjects
{
    public static void IterateAction(List<Base> roomObjects, Type type)
    {
        foreach (Base obj in roomObjects)
        {
            if (type == typeof(IInteractive) && obj is IInteractive interactive)
            {
                interactive.Interact();
            }
            else if (type == typeof(IBreakable) && obj is IBreakable breakable)
            {
                breakable.Break();
            }
            else if (type == typeof(ICollectable) && obj is ICollectable collectable)
            {
                collectable.Collect();
            }
        }
    }
}
