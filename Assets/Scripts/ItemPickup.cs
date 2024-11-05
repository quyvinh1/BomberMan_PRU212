using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public enum ItemType
    {
        ExtraBomb,
        BlastRadius,
        SpeedIncrease,
    }

    public ItemType type;

    private void OnItemPickup(GameObject player)
    {
        PlayerInventory inventory = player.GetComponent<PlayerInventory>();

        switch (type)
        {
            case ItemType.ExtraBomb:
                player.GetComponent<BombController>().AddBomb();
                inventory.AddBombCount(1);
                break;

            case ItemType.BlastRadius:
                player.GetComponent<BombController>().explosionRadius++;
                inventory.AddBlastRadiusCount(1);
                break;

            case ItemType.SpeedIncrease:
                player.GetComponent<MovementController>().speed++;
                inventory.AddSpeedCount(1);
                break;
        }

        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) {
            OnItemPickup(other.gameObject);
        }
    }

}
