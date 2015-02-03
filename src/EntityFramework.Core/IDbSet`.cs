// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using JetBrains.Annotations;
using Microsoft.Data.Entity.ChangeTracking;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Data.Entity
{
    public interface IDbSet<TEntity> : IQueryable<TEntity>, IEnumerable<TEntity>, IQueryable, IEnumerable where TEntity : class
    {
        EntityEntry<TEntity> Add([NotNull]TEntity entity);
        IReadOnlyList<EntityEntry<TEntity>> Add([NotNull]params TEntity[] entities);
        EntityEntry<TEntity> Attach([NotNull]TEntity entity);
        IReadOnlyList<EntityEntry<TEntity>> Attach([NotNull]params TEntity[] entities);
        EntityEntry<TEntity> Remove([NotNull]TEntity entity);
        IReadOnlyList<EntityEntry<TEntity>> Remove([NotNull]params TEntity[] entities);
        EntityEntry<TEntity> Update([NotNull]TEntity entity);
        IReadOnlyList<EntityEntry<TEntity>> Update([NotNull]params TEntity[] entities);
    }
}