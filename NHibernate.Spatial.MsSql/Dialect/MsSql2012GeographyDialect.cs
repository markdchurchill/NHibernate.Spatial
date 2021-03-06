﻿// Copyright 2008 - Ricardo Stuven (rstuven@gmail.com)
//
// This file is part of NHibernate.Spatial.
// NHibernate.Spatial is free software; you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation; either version 2 of the License, or
// (at your option) any later version.
//
// NHibernate.Spatial is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.

// You should have received a copy of the GNU Lesser General Public License
// along with NHibernate.Spatial; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA

using NHibernate.Spatial.Type;
using NHibernate.Type;

namespace NHibernate.Spatial.Dialect
{
    public class MsSql2012GeographyDialect : MsSql2012SpatialDialect
    {
        private static readonly IType geometryType = new CustomType(typeof(MsSqlGeographyType), null);

        public MsSql2012GeographyDialect()
            : base("geography", "NHSP_GEOGRAPHY_COLUMNS", geometryType)
        { }

        /// <summary>
        /// Creates the geometry user type.
        /// </summary>
        /// <returns></returns>
        public override IGeometryUserType CreateGeometryUserType()
        {
            return new MsSqlGeographyType();
        }
    }
}
