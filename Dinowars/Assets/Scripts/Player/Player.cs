using UnityEngine;
using UnityEngine.UI;
using Mirror;

public class Player : NetworkBehaviour
{
    // Static ===================================================================
    public static event System.Action<Player> OnPlayerCreatedEvent;

    // Public ===================================================================
    public event System.Action<string> OnNameChangedEvent;
    public event System.Action<Color> OnColorChangedEvent;
    public event System.Action<double> OnHealthChangedEvent;

    public string PlayerName { get => playerName; set => playerName = value; }
    public Color PlayerColor { get => playerColor; set => playerColor = value; }

    public override void OnStartClient()
    {
        // Fill player's data
        health = 100.0;
        PlayerName = Utils.GenerateRandomName("Resul");
        PlayerColor = Utils.GenerateRandomColor();

        // Tell all listeners the player is created
        OnPlayerCreatedEvent?.Invoke(this);
    }

    // Private ===================================================================
    [SyncVar(hook = nameof(OnHealthChanged))]
    private double health;
    [SyncVar(hook = nameof(OnNameChanged))]
    private string playerName;
    [SyncVar(hook = nameof(OnColorChanged))]
    private Color playerColor = Color.white;

    private void OnNameChanged(string _, string newName)     { OnNameChangedEvent?.Invoke(newName);     }
    private void OnColorChanged(Color _, Color newColor)     { OnColorChangedEvent?.Invoke(newColor);   }
    private void OnHealthChanged(double _, double newHealth) { OnHealthChangedEvent?.Invoke(newHealth); }

    public void Heal(double healingAmount)
    {
        this.health += healingAmount;
        Debug.Log(string.Format("My name is {0} - My new health is {1}", playerName, health));
    }


}