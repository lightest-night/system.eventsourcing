﻿using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace LightestNight.System.EventSourcing.Checkpoints
{
    public interface ICheckpointManager
    {
        /// <summary>
        /// Sets a given checkpoint
        /// </summary>
        /// <param name="checkpoint">The checkpoint to set</param>
        /// <param name="checkpointName">If set, a name to assign the checkpoint (defaults to the calling member's name)</param>
        /// <typeparam name="TCheckpoint">The Type of the checkpoint to set</typeparam>
        Task SetCheckpoint<TCheckpoint>(TCheckpoint checkpoint, [CallerMemberName] string? checkpointName = default);

        /// <summary>
        /// Gets the checkpoint with the given name
        /// </summary>
        /// <param name="checkpointName">The checkpoint name (defaults to the calling member's name)</param>
        /// <typeparam name="TCheckpoint">The Type of the checkpoint to get</typeparam>
        /// <returns>The checkpoint</returns>
        Task<TCheckpoint> GetCheckpoint<TCheckpoint>([CallerMemberName] string? checkpointName = default);
    }
}