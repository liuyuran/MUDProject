using System.Collections.Generic;
using MUDProject.core.bases;
using MUDProject.core.player;
using MUDProject.util;

namespace MUDProject.core.map
{
    /// <summary>
    /// 这里将地图分为三层，第一层是地图区块组成的大世界，第二层是地图单元组成的小世界，第三层是地图单元
    /// 地图区块用于无限制动态加载，地图单元用于显示物体并标注通行性，大世界仅用于协调
    /// 在目前的阶段，大世界概念等同于Manager
    /// 从minecraft的地图生成算法看，他是预先生成一个超大区域的地图，区块生成只是往里填肉而已，这就是为什么地形十分不平滑的原因
    /// </summary>
    public class MapManager: BaseManager, ILookAble
    {
        public Dictionary<Point3, BlockMap> WorldMap = new Dictionary<Point3, BlockMap>();
        
        public MapManager(Player player) : base(player)
        {
        }

        public override void Reset()
        {
            WorldMap.Clear();
        }

        /// <summary>
        /// 如果区域坐标存在，则直接返回，否则生成后返回
        /// </summary>
        /// <param name="block">区块坐标</param>
        /// <param name="unit">区块内坐标</param>
        /// <returns>地图信息</returns>
        public UnitMap GetMapUnit(Point3 block, Point3 unit)
        {
            if (!WorldMap.ContainsKey(block))
            {
                WorldMap[block] = new BlockMap(block);
            }
            return WorldMap[block].GetMapUnit(unit);
        }

        public string Look(Player from)
        {
            throw new System.NotImplementedException();
        }
    }
}