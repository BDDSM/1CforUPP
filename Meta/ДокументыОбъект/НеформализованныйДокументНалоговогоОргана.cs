
using System;
using V82;
using V82.СправочникиСсылка;
using V82.ДокументыСсылка;
using V82.ДокументыОбъект;
using V82.Перечисления;//Ссылка;
namespace V82.ДокументыОбъект
{
	public partial class НеформализованныйДокументНалоговогоОргана:ДокументОбъект
	{
		public V82.СправочникиСсылка.Организации Организация;
		public V82.СправочникиСсылка.НалоговыеОрганы НалоговыйОрган;//Налоговый орган
		public string/*(0)*/ Содержание;
	}
}