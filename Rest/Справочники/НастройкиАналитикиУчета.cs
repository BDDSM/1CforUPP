
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkiAnalitikiUcheta")]
	[Route("/Catalogs/NastrojjkiAnalitikiUcheta/{Code}")]
	public class NastrojjkiAnalitikiUchetaRequest/*�����������������������������*/: V82.�����������������.�����������������������,IReturn<NastrojjkiAnalitikiUchetaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkiAnalitikiUchetaResponse//����������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkiAnalitikiUchetas")]
	[Route("/Catalogs/NastrojjkiAnalitikiUchetas/{Codes}")]
	public class NastrojjkiAnalitikiUchetasRequest/*�����������������������������*/: IReturn<List<NastrojjkiAnalitikiUchetaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkiAnalitikiUchetasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkiAnalitikiUchetasResponse//����������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkiAnalitikiUchetaService /*�����������������������������*/ : Service
	{
		public object Any(NastrojjkiAnalitikiUchetaRequest request)
		{
			return new NastrojjkiAnalitikiUchetaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkiAnalitikiUchetaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�����������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkiAnalitikiUchetaResponse() {Result = "����������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�����������������������.�����������(1);
			}
		}

		public object Get(NastrojjkiAnalitikiUchetasRequest request)
		{
			var ��������� = new List<V82.�����������������.�����������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�����������������������.�����������(���������);
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
