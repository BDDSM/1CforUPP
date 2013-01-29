
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/SokhranennyeNastrojjki")]
	[Route("/Catalogs/SokhranennyeNastrojjki/{Code}")]
	public class SokhranennyeNastrojjkiRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<SokhranennyeNastrojjkiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class SokhranennyeNastrojjkiResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/SokhranennyeNastrojjkis")]
	[Route("/Catalogs/SokhranennyeNastrojjkis/{Codes}")]
	public class SokhranennyeNastrojjkisRequest/*��������������������������*/: IReturn<List<SokhranennyeNastrojjkiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public SokhranennyeNastrojjkisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class SokhranennyeNastrojjkisResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class SokhranennyeNastrojjkiService /*��������������������������*/ : Service
	{
		public object Any(SokhranennyeNastrojjkiRequest request)
		{
			return new SokhranennyeNastrojjkiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(SokhranennyeNastrojjkiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new SokhranennyeNastrojjkiResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(SokhranennyeNastrojjkisRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������.�����������(���������);
					if (������ != null)
					{
						���������.Add(������);
					}
				}
			}
			return ���������;
		}

	}
}
