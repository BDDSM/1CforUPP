
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/NastrojjkaIntervalov")]
	[Route("/Catalogs/NastrojjkaIntervalov/{Code}")]
	public class NastrojjkaIntervalovRequest/*�������������������������*/: V82.�����������������.�������������������,IReturn<NastrojjkaIntervalovRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class NastrojjkaIntervalovResponse//������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/NastrojjkaIntervalovs")]
	[Route("/Catalogs/NastrojjkaIntervalovs/{Codes}")]
	public class NastrojjkaIntervalovsRequest/*�������������������������*/: IReturn<List<NastrojjkaIntervalovRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public NastrojjkaIntervalovsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class NastrojjkaIntervalovsResponse//������������������������
	{
		public string Result {get;set;}
	}


	public class NastrojjkaIntervalovService /*�������������������������*/ : Service
	{
		public object Any(NastrojjkaIntervalovRequest request)
		{
			return new NastrojjkaIntervalovResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(NastrojjkaIntervalovRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.�������������������.�����������(���������);
				if (������ == null)
				{
					return new NastrojjkaIntervalovResponse() {Result = "������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.�������������������.�����������(1);
			}
		}

		public object Get(NastrojjkaIntervalovsRequest request)
		{
			var ��������� = new List<V82.�����������������.�������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.�������������������.�����������(���������);
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
