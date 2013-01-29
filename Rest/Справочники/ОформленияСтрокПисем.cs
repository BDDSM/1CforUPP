
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/OformleniyaStrokPisem")]
	[Route("/Catalogs/OformleniyaStrokPisem/{Code}")]
	public class OformleniyaStrokPisemRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<OformleniyaStrokPisemRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class OformleniyaStrokPisemResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/OformleniyaStrokPisems")]
	[Route("/Catalogs/OformleniyaStrokPisems/{Codes}")]
	public class OformleniyaStrokPisemsRequest/*��������������������������*/: IReturn<List<OformleniyaStrokPisemRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public OformleniyaStrokPisemsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class OformleniyaStrokPisemsResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class OformleniyaStrokPisemService /*��������������������������*/ : Service
	{
		public object Any(OformleniyaStrokPisemRequest request)
		{
			return new OformleniyaStrokPisemResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(OformleniyaStrokPisemRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new OformleniyaStrokPisemResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(OformleniyaStrokPisemsRequest request)
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
