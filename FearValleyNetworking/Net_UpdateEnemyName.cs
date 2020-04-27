namespace FearValleyNetwork
{
    /// <summary>
    /// <inheritdoc/>Tell the server to let other clients know to update client name.
    /// </summary>
    [System.Serializable]
    public class Net_UpdateEnemyName: NetMsg
    {
        /// <summary>
        /// Constructor method.
        /// </summary>
        public Net_UpdateEnemyName()
        {
            OperationCode = (byte)NetOP.Operation.UpdateEnemyName;
        }

        /// <summary>New enemy name.</summary>
        public string Name { set; get; }
    }
}
