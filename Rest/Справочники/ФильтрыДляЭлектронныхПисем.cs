
using System.Globalization;
using System.Collections.Generic;
using ServiceStack.ServiceHost;
using ServiceStack.ServiceInterface;

namespace V82.�����������
{
	[Route("/Catalogs/FiltryDlyaEHlektronnykhPisem")]
	[Route("/Catalogs/FiltryDlyaEHlektronnykhPisem/{Code}")]
	public class FiltryDlyaEHlektronnykhPisemRequest/*��������������������������������*/: V82.�����������������.��������������������������,IReturn<FiltryDlyaEHlektronnykhPisemRequest>
	{
		public string Code {get;set;}
		public string Descr {get;set;}
	}

	public class FiltryDlyaEHlektronnykhPisemResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	[Route("/Catalogs/FiltryDlyaEHlektronnykhPisems")]
	[Route("/Catalogs/FiltryDlyaEHlektronnykhPisems/{Codes}")]
	public class FiltryDlyaEHlektronnykhPisemsRequest/*��������������������������������*/: IReturn<List<FiltryDlyaEHlektronnykhPisemRequest>>
	{
		public string[] Codes {get;set;}
		public string[] Descrs {get;set;}
		public FiltryDlyaEHlektronnykhPisemsRequest(params string[] Codes)
		{
			this.Codes = Codes;
		}
	}

	public class FiltryDlyaEHlektronnykhPisemsResponse//�������������������������������
	{
		public string Result {get;set;}
	}


	public class FiltryDlyaEHlektronnykhPisemService /*��������������������������������*/ : Service
	{
		public object Any(FiltryDlyaEHlektronnykhPisemRequest request)
		{
			return new FiltryDlyaEHlektronnykhPisemResponse {Result = "Tovar, " + request.Code};
		}

		public object Get(FiltryDlyaEHlektronnykhPisemRequest request)
		{
			decimal ��������� = 0;
			if (decimal.TryParse(request.Code, out ���������))
			{
				var ������ = V82.�����������.��������������������������.�����������(���������);
				if (������ == null)
				{
					return new FiltryDlyaEHlektronnykhPisemResponse() {Result = "�������������������������� c ����� '" + request.Code+"' �� �������."};
				}
				return ������;
			}
			else
			{
				return V82.�����������.��������������������������.�����������(1);
			}
		}

		public object Get(FiltryDlyaEHlektronnykhPisemsRequest request)
		{
			var ��������� = new List<V82.�����������������.��������������������������>();
			foreach (var Code in request.Codes)
			{
				decimal ��������� = 0;
				if (decimal.TryParse(Code, out ���������))
				{
					var ������ = V82.�����������.��������������������������.�����������(���������);
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
