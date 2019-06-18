﻿namespace SqlStreamStore.V1.Subscriptions
{
    /// <summary>
    ///     Represents an operation to create a stream store notifier.
    /// </summary>
    /// <param name="readonlyStreamStore"></param>
    /// <returns></returns>
    public delegate IStreamStoreNotifier CreateStreamStoreNotifier(IReadonlyStreamStore readonlyStreamStore);
}