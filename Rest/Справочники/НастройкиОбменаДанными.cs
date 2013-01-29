
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiObmenaDannymi")]
	[Route("/Catalogs/NastrojjkiObmenaDannymi/{Code}")]
	public class NastrojjkiObmenaDannymiRequest/*����������������������������*/: V82.�����������������.����������������������,IReturn<NastrojjkiObmenaDannymiRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiObmenaDannymiResponse//���������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiObmenaDannymis")]
	[Route("/Catalogs/NastrojjkiObmenaDannymis/{Codes}")]
	public class NastrojjkiObmenaDannymisRequest/*����������������������������*/: IReturn<List<NastrojjkiObmenaDannymiRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiObmenaDannymisRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiObmenaDannymisResponse//���������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiObmenaDannymiService /*����������������������������*/ : Service
	{
		public object Any(NastrojjkiObmenaDannymiRequest request)
		{
			return new NastrojjkiObmenaDannymiResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiObmenaDannymiRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.����������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiObmenaDannymiResponse() {Result = "���������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.����������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiObmenaDannymisRequest request)
		{
			var ��������� = new List<V82.�����������������.����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.����������������������.�����������(���������);
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
