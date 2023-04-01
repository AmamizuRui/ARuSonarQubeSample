﻿// --------------------------------------------------------------------------------------------------------------------
// namespace
// --------------------------------------------------------------------------------------------------------------------
namespace ARuSonarQubeSample.Rules.S2757
{
    // --------------------------------------------------------------------------------------------------------------------
    // classes
    // --------------------------------------------------------------------------------------------------------------------

    /// <summary>
    /// "=+" should not be used instead of "+="
    /// </summary>
    /// <remarks>
    /// <para>"=+"、"=-"、"=!"のような演算子ペアを使用していないか確認します。</para>
    /// </remarks>
    public static class RuleS2757
    {
        // --------------------------------------------------------------------------------------------------------------------
        // methods
        // --------------------------------------------------------------------------------------------------------------------

        /// <summary>
        /// 非準拠コード(S2757)
        /// </summary>
        /// <remarks>
        /// <para>逆の単一の演算子 (+=、-= または !=) を意味する演算子のペア ( =+、=- または =! ) を使用すると、</para>
        /// <para>コンパイルおよび実行されますが、期待される結果は得られません。</para>
        /// </remarks>
        public static void NoncompliantCodeS2757()
        {
            int target = -5;
            int num = 3;

            target =- num;  // target = -num;と判断される
            target =+ num;  // target = +num;と判断される
        }

        /// <summary>
        /// 準拠コード(S2757)
        /// </summary>
        /// <remarks>
        /// <para>"+="、"-="、"!="を使用するようにします。</para>
        /// </remarks>
        public static void CompliantCodeS2757()
        {
            int target = -5;
            int num = 3;

            target = -num;
            target += num;
        }
    }
}
