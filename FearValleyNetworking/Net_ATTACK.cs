﻿namespace FearValleyNetwork
{
    /// <summary>
    /// <inheritdoc/>Tell the server that a troop has taken damage.
    /// See <see cref="Net_MOVE"/> to send move data.
    /// <seealso cref="Net_RETREAT"/>
    /// </summary>
    [System.Serializable]
    public class Net_ATTACK : NetMsg
    {
        /// <summary>
        /// Constructor method.
        /// </summary>
        public Net_ATTACK()
        {
            OperationCode = (byte) NetOP.Operation.ATTACK;
        }
        /// <summary>Specific troop that has taken damage.</summary>
        public int TroopID { set; get; }
        /// <summary>The damage to be taken by the troop.</summary>
        public int DamageTaken { set; get; }

    }
}