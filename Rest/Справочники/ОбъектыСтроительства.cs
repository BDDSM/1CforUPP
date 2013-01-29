
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/ObektyStroitelstva")]
	[Route("/Catalogs/ObektyStroitelstva/{Code}")]
	public class ObektyStroitelstvaRequest/*��������������������������*/: V82.�����������������.��������������������,IReturn<ObektyStroitelstvaRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class ObektyStroitelstvaResponse//�������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/ObektyStroitelstvas")]
	[Route("/Catalogs/ObektyStroitelstvas/{Codes}")]
	public class ObektyStroitelstvasRequest/*��������������������������*/: IReturn<List<ObektyStroitelstvaRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public ObektyStroitelstvasRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class ObektyStroitelstvasResponse//�������������������������
	{
		public string Result {get;set;}
	}


	public class ObektyStroitelstvaService /*��������������������������*/ : Service
	{
		public object Any(ObektyStroitelstvaRequest request)
		{
			return new ObektyStroitelstvaResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(ObektyStroitelstvaRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������.�����������(���������);
				if (������ == null)
				{
					return new ObektyStroitelstvaResponse() {Result = "�������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������.�����������(1);
			}
		}

		public object Get(ObektyStroitelstvasRequest request)
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
