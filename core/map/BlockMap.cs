using System.Collections.Generic;
using MUDProject.util;

namespace MUDProject.core.map
{
    /// <summary>
    /// 地图区块
    /// </summary>
    public class BlockMap
    {
        private static readonly long SideLength = 100;
        public Dictionary<Point3, UnitMap> Map = new Dictionary<Point3, UnitMap>();
        
        public BlockMap(Point3 block)
        {
            // TODO 地形生成算法填充整个区块
            for (long i = 0; i < 100; i++)
            {
                for (long j = 0; j < 100; j++)
                {
                    var point = new Point3
                    {
                        X = i,
                        Y = j,
                        Z = 0
                    };
                    Map[point] = new UnitMap();
                }
            }
        }
        
        /// <summary>
        /// 如果区域坐标存在，则直接返回，否则生成后返回
        /// </summary>
        /// <param name="unit">区块内坐标</param>
        /// <returns>地图信息</returns>
        public UnitMap GetMapUnit(Point3 unit)
        {
            return Map[unit];
        }
    }
}