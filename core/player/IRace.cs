using MUDProject.core.enums;

namespace MUDProject.core.player
{
    /// <summary>
    /// 种族抽象类
    /// </summary>
    public interface IRace
    {
        /// <summary>
        /// 获取称谓，目前想的是使用视角来区分称谓，比如幻1中的男主，长辈叫姬轩，熟人叫伯雅，陌生人叫姬伯雅
        /// </summary>
        /// <param name="from">从谁的视角看</param>
        /// <param name="to">看向谁</param>
        /// <param name="name">名字完整结构</param>
        /// <returns></returns>
        string GetPlayerName(Player from, Player to, Name name);

        /// <summary>
        /// 种族名
        /// </summary>
        /// <param name="gender">角色性别</param>
        /// <returns>描述文本</returns>
        string GetRaceName(Gender gender);

        /// <summary>
        /// 获取名词量纲
        /// </summary>
        /// <returns>量纲名</returns>
        string GetDimension();
    }
}